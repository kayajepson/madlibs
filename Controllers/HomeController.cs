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

    [Route("/madLibTwo")]
    public ActionResult MadlibTwo(string bodyPartML2, string activityML2, string foodML2, string nounML2, string placeML2, string nameML2)

    {
      MadlibVariableTwo mySecondMadlibVariable = new MadlibVariableTwo();
      mySecondMadlibVariable.BodyPartML2 = bodyPartML2;
      mySecondMadlibVariable.ActivityML2 = activityML2;
      mySecondMadlibVariable.FoodML2 = foodML2;
      mySecondMadlibVariable.NounML2 = nounML2;
      mySecondMadlibVariable.PlaceML2 = placeML2;
      mySecondMadlibVariable.NameML2 = nameML2;
      return View(mySecondMadlibVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

  }
}
