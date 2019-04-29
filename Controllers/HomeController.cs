using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/madLibOne")]
    public ActionResult MadlibOne(string adjectiveOne, string adjectiveTwo, string nounOne, string nounTwo, string pluralNounOne, string gameOne, string pluralNounTwo, string verbIngOne, string verbIngTwo,
    string pluralNounThree, string verbIngThree, string nounThree, string plantOne, string bodyPart, string placeOne, string verbIngFour, string adjectiveThree, string numberOne, string pluralNounFour)

    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      myMadlibVariable.SetAdjectiveOne(adjectiveOne);
      myMadlibVariable.SetAdjectiveTwo(adjectiveTwo);
      myMadlibVariable.SetNounOne(nounOne);
      myMadlibVariable.SetNounTwo(nounTwo);
      myMadlibVariable.SetPluralNounOne(pluralNounOne);
      myMadlibVariable.SetGameOne(gameOne);
      myMadlibVariable.SetPluralNounTwo(pluralNounTwo);
      myMadlibVariable.SetVerbIngOne(verbIngOne);
      myMadlibVariable.SetVerbIngTwo(verbIngTwo);
      myMadlibVariable.SetPluralNounThree(pluralNounThree);
      myMadlibVariable.SetVerbIngThree(verbIngThree);
      myMadlibVariable.SetNounThree(nounThree);
      myMadlibVariable.SetPlantOne(plantOne);
      myMadlibVariable.SetBodyPart(bodyPart);
      myMadlibVariable.SetPlaceOne(placeOne);
      myMadlibVariable.SetVerbIngFour(verbIngFour);
      myMadlibVariable.SetAdjectiveThree(adjectiveThree);
      myMadlibVariable.SetNumberOne(numberOne);
      myMadlibVariable.SetPluralNounFour(pluralNounFour);
      return View(myMadlibVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

  }
}
