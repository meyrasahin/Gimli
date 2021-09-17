using Gimli.Data.Entities;
using Gimli.Data.Entities.MyClothClasses;
using Gimli.Data.Repository.Base;
using Gimli.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Gimli.Controllers
{
    public class HomeController : Controller
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

        public HomeController(IRepository<Outfit> outfitRepo, IRepository<HeadClothes> headRepo, IRepository<ArmClothes> armRepo, IRepository<BodyClothes> bodyRepo, IRepository<FeetClothes> feetRepo, IRepository<LegsClothes> legsRepo, IRepository<OutfitHeadCloth> oheadRepo, IRepository<OutfitArmCloth> oarmRepo, IRepository<OutfitBodyCloth> obodyRepo, IRepository<OutfitFeetCloth> ofeetRepo, IRepository<OutfitLegsCloth> olegsRepo)
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        public async Task<JsonResult> GetClothes(string name)
        {
            OutfitViewModel toBeReturned = new OutfitViewModel();
            var selectedOutfit =  _outfitRepo.GetAll().Where(i => i.Name == name).FirstOrDefault();
            toBeReturned.Outfit = selectedOutfit;

            var headIDs = _outfitHead.GetAll().Where(i => i.OutfitId == selectedOutfit.Id).Select(j => j.HeadClothId).ToList();
            foreach (var headid in headIDs)
            {
                toBeReturned.HeadClothes.Add(await _headRepo.GetById(headid));
            }

            var armIDs = _outfitArm.GetAll().Where(i => i.OutfitId == selectedOutfit.Id).Select(j => j.ArmClothId).ToList();
            foreach (var armid in armIDs)
            {
                toBeReturned.ArmClothes.Add(await _armRepo.GetById(armid));
            }

            var bodyIDs = _outfitBody.GetAll().Where(i => i.OutfitId == selectedOutfit.Id).Select(j => j.BodyClothId).ToList();
            foreach (var bodyid in bodyIDs)
            {
                toBeReturned.BodyClothes.Add(await _bodyRepo.GetById(bodyid));
            }

            var legIDs = _outfitLegs.GetAll().Where(i => i.OutfitId == selectedOutfit.Id).Select(j => j.LegsClothId).ToList();
            foreach (var legid in legIDs)
            {
                toBeReturned.LegsClothes.Add(await _legsRepo.GetById(legid));
            }

            var feetIDs = _outfitFeet.GetAll().Where(i => i.OutfitId == selectedOutfit.Id).Select(j => j.FeetClothId).ToList();
            foreach (var feetid in feetIDs)
            {
                toBeReturned.FeetClothes.Add(await _feetRepo.GetById(feetid));
            }

            return Json(toBeReturned);
        }


    }
}
