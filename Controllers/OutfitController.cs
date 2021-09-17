using Gimli.Data.Entities;
using Gimli.Data.Entities.MyClothClasses;
using Gimli.Data.Repository.Base;
using Gimli.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Controllers
{
    public class OutfitController : Controller
    {
        private readonly IRepository<Outfit> _outfitRepo;
        private readonly IRepository<HeadClothes> _headRepo;
        private readonly IRepository<ArmClothes> _armRepo;
        private readonly IRepository<BodyClothes> _bodyRepo;
        private readonly IRepository<FeetClothes> _feetRepo;
        private readonly IRepository<LegsClothes> _legsRepo;


        private readonly IRepository<OutfitHeadCloth> _outfitHead;
        private readonly IRepository<OutfitBodyCloth> _outfitBody;
        private readonly IRepository<OutfitArmCloth> _outfitArm;
        private readonly IRepository<OutfitLegsCloth> _outfitLegs;
        private readonly IRepository<OutfitFeetCloth> _outfitFeet;


        public OutfitController(IRepository<Outfit> outfitRepo, IRepository<HeadClothes> headRepo, IRepository<ArmClothes> armRepo, IRepository<BodyClothes> bodyRepo, IRepository<FeetClothes> feetRepo, IRepository<LegsClothes> legsRepo, IRepository<OutfitHeadCloth> oheadRepo, IRepository<OutfitArmCloth> oarmRepo, IRepository<OutfitBodyCloth> obodyRepo, IRepository<OutfitFeetCloth> ofeetRepo, IRepository<OutfitLegsCloth> olegsRepo)
        {
            _outfitRepo = outfitRepo;
            _headRepo = headRepo;
            _armRepo = armRepo;
            _bodyRepo = bodyRepo;
            _feetRepo = feetRepo;
            _legsRepo = legsRepo;


            _outfitHead = oheadRepo;
            _outfitBody = obodyRepo;
            _outfitArm = oarmRepo;
            _outfitLegs = olegsRepo;
            _outfitFeet = ofeetRepo;

        }
       
        public async Task<IActionResult> Index()
        {
            List<OutfitViewModel> toBeReturned = new List<OutfitViewModel>();
            
            var outfitIDs = _outfitRepo.GetAll().Select(i => i.Id).ToList();
            foreach (var outfitid in outfitIDs)
            {
                OutfitViewModel newModel = new OutfitViewModel();
                newModel.Outfit = await _outfitRepo.GetById(outfitid);
                var headIDs = _outfitHead.GetAll().Where(i => i.OutfitId == outfitid).Select(j => j.HeadClothId).ToList();
                foreach (var headid in headIDs)
                {
                    newModel.HeadClothes.Add(await _headRepo.GetById(headid));
                }

                var armIDs = _outfitArm.GetAll().Where(i => i.OutfitId == outfitid).Select(j => j.ArmClothId).ToList();
                foreach (var armid in armIDs)
                {
                    newModel.ArmClothes.Add(await _armRepo.GetById(armid));
                }

                var bodyIDs = _outfitBody.GetAll().Where(i => i.OutfitId == outfitid).Select(j => j.BodyClothId).ToList();
                foreach (var bodyid in bodyIDs)
                {
                    newModel.BodyClothes.Add(await _bodyRepo.GetById(bodyid));
                }

                var legIDs = _outfitLegs.GetAll().Where(i => i.OutfitId == outfitid).Select(j => j.LegsClothId).ToList();
                foreach (var legid in legIDs)
                {
                    newModel.LegsClothes.Add(await _legsRepo.GetById(legid));
                }

                var feetIDs = _outfitFeet.GetAll().Where(i => i.OutfitId == outfitid).Select(j => j.FeetClothId).ToList();
                foreach (var feetid in feetIDs)
                {
                    newModel.FeetClothes.Add(await _feetRepo.GetById(feetid));
                }
                toBeReturned.Add(newModel);
            }
            
            return View(toBeReturned);
        }
       
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.head = _headRepo.GetAll().ToList();
            ViewBag.arm = _armRepo.GetAll().ToList();
            ViewBag.body = _bodyRepo.GetAll().ToList();
            ViewBag.legs = _legsRepo.GetAll().ToList();
            ViewBag.feet = _feetRepo.GetAll().ToList();

            ViewBag.hCount = _headRepo.GetAll().ToList().Count();
            ViewBag.aCount = _armRepo.GetAll().ToList().Count();
            ViewBag.bCount = _bodyRepo.GetAll().ToList().Count();
            ViewBag.lCount = _legsRepo.GetAll().ToList().Count();
            ViewBag.fCount = _feetRepo.GetAll().ToList().Count();

            return View();
        }
      
        public async Task<JsonResult> CreateOutfit(string name)
        {
            Outfit newOutfit = new Outfit()
            {
                Name = name
            };
            var idx = await _outfitRepo.CreateRnID(newOutfit);

            return Json(idx);
        }

        public JsonResult CreateOutfitCloth(string[] values)
        {
            string valuesStr = values[0].ToString();
            string[] myValues = valuesStr.Split('-');
            List<OutfitHeadCloth> heads = new List<OutfitHeadCloth>();
            List<OutfitArmCloth> arms = new List<OutfitArmCloth>();
            List<OutfitBodyCloth> bodys = new List<OutfitBodyCloth>();
            List<OutfitLegsCloth> legs = new List<OutfitLegsCloth>();
            List<OutfitFeetCloth> feets = new List<OutfitFeetCloth>();

            int id = 0;
            foreach (var item in myValues[5].Split(','))
            {
                if (!item.Equals(""))
                    id = Int32.Parse(item);
            }
            foreach (var item in myValues[0].Split(','))
            {
                if (!item.Equals(""))
                {
                    var headss = _headRepo.GetAll().Where(i => i.Name == item).FirstOrDefault();
                    OutfitHeadCloth oheads = new OutfitHeadCloth
                    {
                        OutfitId = id,
                        HeadClothId = headss.Id
                    };
                    heads.Add(oheads);
                    _outfitHead.CreateNonAsync(oheads);
                }
            }
            foreach (var item in myValues[1].Split(','))
            {
                if (!item.Equals(""))
                {
                    var bodyss = _bodyRepo.GetAll().Where(i => i.Name == item).FirstOrDefault();
                    OutfitBodyCloth obodys = new OutfitBodyCloth
                    {
                        OutfitId = id,
                        BodyClothId = bodyss.Id
                    };
                    bodys.Add(obodys);
                    _outfitBody.CreateNonAsync(obodys);
                }
            }
            foreach (var item in myValues[2].Split(','))
            {
                if (!item.Equals(""))
                {
                    var armss = _armRepo.GetAll().Where(i => i.Name == item).FirstOrDefault();
                    OutfitArmCloth oarms = new OutfitArmCloth
                    {
                        OutfitId = id,
                        ArmClothId = armss.Id
                    };
                    arms.Add(oarms);
                    _outfitArm.CreateNonAsync(oarms);
                }
            }
            foreach (var item in myValues[3].Split(','))
            {
                if (!item.Equals(""))
                {
                    var legss = _legsRepo.GetAll().Where(i => i.Name == item).FirstOrDefault();
                    OutfitLegsCloth legsx = new OutfitLegsCloth
                    {
                        OutfitId = id,
                        LegsClothId = legss.Id
                    };
                    legs.Add(legsx);
                    _outfitLegs.CreateNonAsync(legsx);
                }
            }
            foreach (var item in myValues[4].Split(','))
            {
                if (!item.Equals(""))
                {
                    var feetss = _feetRepo.GetAll().Where(i => i.Name == item).FirstOrDefault();
                    OutfitFeetCloth feetsx = new OutfitFeetCloth
                    {
                        OutfitId = id,
                        FeetClothId = feetss.Id
                    };
                    feets.Add(feetsx);
                    _outfitFeet.CreateNonAsync(feetsx);
                }
            }
            return Json("");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            OutfitViewModel model = new OutfitViewModel();
            model.Outfit = await _outfitRepo.GetById(id);

            var heads = _outfitHead.GetAll().Where(i => i.OutfitId == id).Select(j => j.HeadClothId).ToList();
            foreach (var idd in heads)
            {
                model.HeadClothes.Add(await _headRepo.GetById(idd));
            }

            var arms = _outfitArm.GetAll().Where(i => i.OutfitId == id).Select(j => j.ArmClothId).ToList();
            foreach (var idd in arms)
            {
                model.ArmClothes.Add(await _armRepo.GetById(idd));
            }


            var bodys = _outfitBody.GetAll().Where(i => i.OutfitId == id).Select(j => j.BodyClothId).ToList();
            foreach (var idd in bodys)
            {
                model.BodyClothes.Add(await _bodyRepo.GetById(idd));
            }


            var legs = _outfitLegs.GetAll().Where(i => i.OutfitId == id).Select(j => j.LegsClothId).ToList();
            foreach (var idd in legs)
            {
                model.LegsClothes.Add(await _legsRepo.GetById(idd));
            }

            var feets = _outfitFeet.GetAll().Where(i => i.OutfitId == id).Select(j => j.FeetClothId).ToList();
            foreach (var idd in feets)
            {
                model.FeetClothes.Add(await _feetRepo.GetById(idd));
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _outfitRepo.Delete(id);
            return RedirectToAction("Index");
        }
    
        public async Task<JsonResult> DeleteCloth(string value)
        {
            var values = value.Split("|");
            var part = values[0];
            var oID = Int32.Parse(values[1]);
            var hID = Int32.Parse(values[2]);
            switch (part)
            {
                case "head":
                    var deletedHeadId = _outfitHead.GetAll().Where(i => i.OutfitId == oID && i.HeadClothId == hID).Select(j => j.Id).FirstOrDefault();
                    await _outfitHead.Delete(deletedHeadId);
                    break;
                case "body":
                    var deletedBodyId = _outfitBody.GetAll().Where(i => i.OutfitId == oID && i.BodyClothId == hID).Select(j => j.Id).FirstOrDefault();
                    await _outfitBody.Delete(deletedBodyId);
                    break;
                case "arm":
                    var deletedArmId = _outfitArm.GetAll().Where(i => i.OutfitId == oID && i.ArmClothId == hID).Select(j => j.Id).FirstOrDefault();
                    await _outfitArm.Delete(deletedArmId);
                    break;
                case "legs":
                    var deletedLegsId = _outfitLegs.GetAll().Where(i => i.OutfitId == oID && i.LegsClothId == hID).Select(j => j.Id).FirstOrDefault();
                    await _outfitLegs.Delete(deletedLegsId);
                    break;
                case "feet":
                    var deletedFeetId = _outfitFeet.GetAll().Where(i => i.OutfitId == oID && i.FeetClothId == hID).Select(j => j.Id).FirstOrDefault();
                    await _outfitFeet.Delete(deletedFeetId);
                    break;
            }
            return Json("");
        }
    
        public JsonResult GetClothes(string part)
        {
            switch (part)
            {
                case "head":
                    return Json(_headRepo.GetAll().ToList());
                case "body":
                    return Json(_bodyRepo.GetAll().ToList());
                case "arm":
                    return Json(_armRepo.GetAll().ToList());
                case "legs":
                    return Json(_legsRepo.GetAll().ToList());
                case "feet":
                    return Json(_feetRepo.GetAll().ToList());
            }
            return Json("");
        }

        public async Task<JsonResult> UpdateOutfit(string value)
        {
            var values = value.Split("|");
            var outfitId = Int32.Parse(values[0]);
            var outfitName = values[1];
            var hId = Int32.Parse(values[2]);
            var bId = Int32.Parse(values[3]);
            var aId = Int32.Parse(values[4]);
            var lId = Int32.Parse(values[5]);
            var fId = Int32.Parse(values[6]);

            var outfit = await _outfitRepo.GetById(outfitId);
            outfit.Name = outfitName;
            await _outfitRepo.Update(outfit);

            await _outfitHead.Create(new OutfitHeadCloth
            {
                OutfitId = outfitId,
                HeadClothId = hId
            });
            await _outfitBody.Create(new OutfitBodyCloth
            {
                OutfitId = outfitId,
                BodyClothId = bId
            });
            await _outfitArm.Create(new OutfitArmCloth
            {
                OutfitId = outfitId,
                ArmClothId = aId
            });
            await _outfitLegs.Create(new OutfitLegsCloth
            {
                OutfitId = outfitId,
                LegsClothId = lId
            });
            await _outfitFeet.Create(new OutfitFeetCloth
            {
                OutfitId = outfitId,
                FeetClothId = fId
            });
            return Json("");
        }

        

        //public async Task<JsonResult> UpdateOutfit(string[] value)
        //{
        //    var values = value.Split("|");
        //    var outfitId = Int32.Parse(values[0]);
        //    var outfitName = values[1];
        //    //var hId = Int32.Parse(values[2]);
        //    //var bId = Int32.Parse(values[3]);
        //    //var aId = Int32.Parse(values[4]);
        //    //var lId = Int32.Parse(values[5]);
        //    //var fId = Int32.Parse(values[6]);

        //    var outfit = await _outfitRepo.GetById(model.OutfitId);
        //    outfit.Name = model.Name;
        //    await _outfitRepo.Update(outfit);

        //    foreach (var id in model.HeadIds)
        //    {
        //        await _outfitHead.Create(new OutfitHeadCloth
        //        {
        //            OutfitId = model.OutfitId,
        //            HeadClothId = Int32.Parse(id)
        //        });
        //    }

        //    foreach (var id in model.BodyIds)
        //    {
        //        await _outfitBody.Create(new OutfitBodyCloth
        //        {
        //            OutfitId = model.OutfitId,
        //            BodyClothId = Int32.Parse(id)
        //        });
        //    }
        //    foreach (var id in model.ArmIds)
        //    {
        //        await _outfitArm.Create(new OutfitArmCloth
        //        {
        //            OutfitId = model.OutfitId,
        //            ArmClothId = Int32.Parse(id)
        //        });
        //    }
        //    foreach (var id in model.LegsIds)
        //    {
        //        await _outfitLegs.Create(new OutfitLegsCloth
        //        {
        //            OutfitId = model.OutfitId,
        //            LegsClothId = Int32.Parse(id)
        //        });
        //    }
        //    foreach (var id in model.FeetIds)
        //    {
        //        await _outfitFeet.Create(new OutfitFeetCloth
        //        {
        //            OutfitId = model.OutfitId,
        //            FeetClothId = Int32.Parse(id)
        //        });
        //    }

        //    return Json("");
        //}
    }
}
