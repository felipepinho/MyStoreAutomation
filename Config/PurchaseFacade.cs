using TestProject.SDK.PageObjects;

namespace MyStoreAutomation.Config
{
    public class PurchaseFacade
    {
        private T GetPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Driver.WebDriver, page);
            return page;
        }
    }
}
