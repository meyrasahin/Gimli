using Gimli.Data.Entities;
using Gimli.Data.Entities.Enums;
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
    public class ClothController : Controller
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


        public ClothController(IRepository<Outfit> outfitRepo, IRepository<HeadClothes> headRepo, IRepository<ArmClothes> armRepo, IRepository<BodyClothes> bodyRepo, IRepository<FeetClothes> feetRepo, IRepository<LegsClothes> legsRepo, IRepository<OutfitHeadCloth> oheadRepo, IRepository<OutfitArmCloth> oarmRepo, IRepository<OutfitBodyCloth> obodyRepo, IRepository<OutfitFeetCloth> ofeetRepo, IRepository<OutfitLegsCloth> olegsRepo)
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
        public IActionResult Index()
        {
            var headclothes = _headRepo.GetAll().ToList();
            var headwViewModel = headclothes.Select(p => new ClothViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                Type = Enum.GetName(typeof(HeadClothType), p.Type)
            }).ToList();
            ViewBag.head = headwViewModel;

            var bodyclothes = _bodyRepo.GetAll().ToList();
            var bodywViewModel = bodyclothes.Select(p => new ClothViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                Type = Enum.GetName(typeof(BodyClothType), p.Type)
            }).ToList();
            ViewBag.body = bodywViewModel;

            var armclothes = _armRepo.GetAll().ToList();
            var armwViewModel = armclothes.Select(p => new ClothViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                Type = Enum.GetName(typeof(ArmClothType), p.Type)
            }).ToList();
            ViewBag.arm = armwViewModel;

            var legclothes = _legsRepo.GetAll().ToList();
            var legwViewModel = legclothes.Select(p => new ClothViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                Type = Enum.GetName(typeof(LegsClothType), p.Type)
            }).ToList();
            ViewBag.leg = legwViewModel;

            var feetclothes = _feetRepo.GetAll().ToList();
            var feetwViewModel = feetclothes.Select(p => new ClothViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                Type = Enum.GetName(typeof(FeetClothType), p.Type)
            }).ToList();
            ViewBag.feet = feetwViewModel;

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Create(ClothCreateModel item)
        {
            if (!ModelState.IsValid)
            {
                return Json("Create");
            }

            switch (item.BodyPart)
            {
                case "Head":
                    HeadClothes headCloth = new HeadClothes()
                    {
                        Name = item.Name,
                        Image = item.Image,
                        Type = (HeadClothType)Enum.Parse(typeof(HeadClothType), item.ClothType)
                    };

                    await _headRepo.Create(headCloth);
                    break;
                case "Body":
                    BodyClothes bodyCloth = new BodyClothes()
                    {
                        Name = item.Name,
                        Image = item.Image,
                        Type = (BodyClothType)Enum.Parse(typeof(BodyClothType), item.ClothType)
                    };

                    await _bodyRepo.Create(bodyCloth);
                    break;
                case "Arm":
                    ArmClothes armCloth = new ArmClothes()
                    {
                        Name = item.Name,
                        Image = item.Image,
                        Type = (ArmClothType)Enum.Parse(typeof(ArmClothType), item.ClothType)
                    };

                    await _armRepo.Create(armCloth);
                    break;
                case "Legs":
                    LegsClothes legsCloth = new LegsClothes()
                    {
                        Name = item.Name,
                        Image = item.Image,
                        Type = (LegsClothType)Enum.Parse(typeof(LegsClothType), item.ClothType)
                    };

                    await _legsRepo.Create(legsCloth);
                    break;
                case "Feet":
                    FeetClothes feetCloth = new FeetClothes()
                    {
                        Name = item.Name,
                        Image = item.Image,
                        Type = (FeetClothType)Enum.Parse(typeof(FeetClothType), item.ClothType)
                    };

                    await _feetRepo.Create(feetCloth);
                    break;
            }


            return Json("Index");
        }

        public JsonResult GetClothTypes(string type)
        {
            switch (type)
            {
                case "Head":
                    return Json(Enum.GetNames(typeof(HeadClothType)));
                case "Body":
                    return Json(Enum.GetNames(typeof(BodyClothType)));
                case "Arm":
                    return Json(Enum.GetNames(typeof(ArmClothType)));
                case "Legs":
                    return Json(Enum.GetNames(typeof(LegsClothType)));
                default:
                    return Json(Enum.GetNames(typeof(FeetClothType)));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id, string part)
        {
            ViewBag.part = part;
            ViewBag.id = id;
            switch (part)
            {
                case "head":
                    ViewBag.cloth = await _headRepo.GetById(id);
                    break;
                case "body":
                    ViewBag.cloth = await _bodyRepo.GetById(id);
                    break;
                case "arm":
                    ViewBag.cloth = await _armRepo.GetById(id);
                    break;
                case "legs":
                    ViewBag.cloth = await _legsRepo.GetById(id);
                    break;
                case "feet":
                    ViewBag.cloth = await _feetRepo.GetById(id);
                    break;
            }
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Update(string name)
        {
            var inputs = name.Split("|");
            var clothName = inputs[0];
            var image = inputs[1];
            var ID = Int32.Parse(inputs[2]);
            var part = inputs[3];

            switch (part)
            {
                case "head":
                    var headCloth = await _headRepo.GetById(ID);
                    headCloth.Name = clothName;
                    headCloth.Image = image;
                    await _headRepo.Update(headCloth);
                    return Json("Index");
                case "body":
                    var bodyCloth = await _bodyRepo.GetById(ID);
                    bodyCloth.Name = clothName;
                    bodyCloth.Image = image;
                    await _bodyRepo.Update(bodyCloth);
                    return Json("Index");
                case "arm":
                    var armCloth = await _armRepo.GetById(ID);
                    armCloth.Name = clothName;
                    armCloth.Image = image;
                    await _armRepo.Update(armCloth);
                    return Json("Index");
                case "legs":
                    var legsCloth = await _legsRepo.GetById(ID);
                    legsCloth.Name = clothName;
                    legsCloth.Image = image;
                    await _legsRepo.Update(legsCloth);
                    return Json("Index");
                case "feet":
                    var feetCloth = await _feetRepo.GetById(ID);
                    feetCloth.Name = clothName;
                    feetCloth.Image = image;
                    await _feetRepo.Update(feetCloth);
                    return Json("Index");
            }
            return Json("Create");
        }

        public async Task<IActionResult> Delete(int id, string part)
        {
            switch (part)
            {
                case "head":
                    await _headRepo.Delete(id);
                    foreach (var item in _outfitHead.GetAll().Where(i => i.HeadClothId == id).Select(j => j.Id).ToList())
                    {
                        await _outfitHead.Delete(item);
                    }
                    break;
                case "body":
                    await _bodyRepo.Delete(id);
                    foreach (var item in _outfitBody.GetAll().Where(i => i.BodyClothId == id).Select(j => j.Id).ToList())
                    {
                        await _outfitBody.Delete(item);
                    }
                    break;
                case "arm":
                    await _armRepo.Delete(id);
                    foreach (var item in _outfitArm.GetAll().Where(i => i.ArmClothId == id).Select(j => j.Id).ToList())
                    {
                        await _outfitArm.Delete(item);
                    }
                    break;
                case "legs":
                    await _legsRepo.Delete(id);
                    foreach (var item in _outfitLegs.GetAll().Where(i => i.LegsClothId == id).Select(j => j.Id).ToList())
                    {
                        await _outfitLegs.Delete(item);
                    }
                    break;
                case "feet":
                    await _feetRepo.Delete(id);
                    foreach (var item in _outfitFeet.GetAll().Where(i => i.FeetClothId == id).Select(j => j.Id).ToList())
                    {
                        await _outfitFeet.Delete(item);
                    }
                    break;
            }
            return RedirectToAction("Index");
        }


    }




}
