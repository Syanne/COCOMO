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

        #region Basic Indexes
        [HttpGet]
        public ActionResult BasicIndexes()
        {
            BasicIndexesGroup basicIndexesGroup = new BasicIndexesGroup();
            Deserializer.Deserialize(ref basicIndexesGroup);
            return View(basicIndexesGroup);
        }
        
        [HttpPost]
        public ActionResult BasicIndexes(double basicIndexesGroup)
        {
            return View(basicIndexesGroup);
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
            return View(intermediateIndexesGroup);
        }
        #endregion

        #region Early Design
        public ActionResult CocomoIIEarlyDesign()
        {
            return View();
        }
        #endregion

        #region Post Architecture
        public ActionResult CocomoIIPA()
        {
            return View();
        }
        #endregion
    }
}