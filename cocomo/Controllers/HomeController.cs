using cocomo.Models;
using cocomo.Models.GroupModels;
using System.Linq;
using System.Web.Mvc;

namespace cocomo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Result(ResultModel resultModel)
        {
            return View(resultModel);
        }

        #region Basic Indexes
        [HttpGet]
        public ActionResult BasicIndexes()
        {
            BasicIndexesGroup basicIndexesGroup = new BasicIndexesGroup();
            Deserializer.Deserialize(ref basicIndexesGroup);
            return View(basicIndexesGroup);
        }
        
        [HttpPost]
        public ActionResult BasicIndexes(BasicIndexesGroup basicIndexesGroup)
        {
            ResultModel rm = new ResultModel("", basicIndexesGroup.TM, basicIndexesGroup.PM);
            return View("Result", rm);
        }
        #endregion

        #region Intermediate
        [HttpGet]
        public ActionResult Intermediate()
        {
            IntermediateIndexesGroup intermediateIndexesGroup = new IntermediateIndexesGroup();
            Deserializer.Deserialize(ref intermediateIndexesGroup);
            return View(intermediateIndexesGroup);
        }

        [HttpPost]
        public ActionResult Intermediate(IntermediateIndexesGroup intermediateIndexesGroup)
        {
            ResultModel rm = new ResultModel("", intermediateIndexesGroup.TM, intermediateIndexesGroup.PM);
            return View("Result", rm);
        }
        #endregion

        #region Early Design
        [HttpGet]
        public ActionResult CocomoIIEarlyDesign()
        {
            CocomoIIEDGroup cocomoIIEDGroup = new CocomoIIEDGroup();
            Deserializer.Deserialize(ref cocomoIIEDGroup);
            foreach (var item in cocomoIIEDGroup.CocomoIIEDItems)
                item.SelectedItem = item.nominal;
            return View(cocomoIIEDGroup);
        }

        [HttpPost]
        public ActionResult CocomoIIEarlyDesign(CocomoIIEDGroup cocomoIIEDGroup)
        {
            ResultModel rm = new ResultModel("", cocomoIIEDGroup.TM, cocomoIIEDGroup.PM);
            return View("Result", rm);
        }
        #endregion

        #region Post Architecture
        [HttpGet]
        public ActionResult CocomoIIPA()
        {
            CocomoIIPAGroup cocomoIIPAGroup = new CocomoIIPAGroup();
            Deserializer.Deserialize(ref cocomoIIPAGroup);

            foreach (var item in cocomoIIPAGroup.CocomoIIPAItems)
                item.SelectedItem = item.nominal;

            return View(cocomoIIPAGroup);
        }
        [HttpPost]
        public ActionResult CocomoIIPA(CocomoIIPAGroup cocomoIIPAGroup)
        {
            ResultModel rm = new ResultModel("", cocomoIIPAGroup.TM, cocomoIIPAGroup.PM);
            return View("Result", rm);
        }
        #endregion
    }
}