using TechTalk.SpecFlow;
using SFA.DAS.TransferMatching.UITests.Project.Helper;
using SFA.DAS.TransferMatching.UITests.Project.PageObjects;

namespace SFA.DAS.TransferMatching.UITests.Project.Steps;

[Binding]
public class PledgeSteps
{
    private readonly ObjectContext _context;
    public PledgeSteps(ObjectContext context) => _context = context;

    [When("the levy employer can create pledge using default criteria")]
    public async Task WhenCreatePledgeDefault()
    {
        var create = _context.GetPage<CreatePledgePage>();
        if (create is CreatePledgePage cp)
        {
            await cp.FillAmountAsync("1000");
            await cp.SubmitAsync();
        }
    }

    [Then("the levy employer can view pledges from verification page")]
    public async Task ThenViewPledges()
    {
        var list = _context.GetPage<PledgeListPage>();
        if (list is PledgeListPage pl)
        {
            var has = await pl.HasPledgeWithAmountAsync("1000");
            NUnit.Framework.Assert.IsTrue(has);
        }
    }
}
