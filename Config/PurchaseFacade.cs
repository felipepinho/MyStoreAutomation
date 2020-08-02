using MyStoreAutomation.Pages.ProductPage;
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

        private ProductPage ProductPage => GetPages<ProductPage>();

        public void PurchaseProduct(string product, string productPrice)
        {
            ProductPage.Navigate(product);
        }
    }
}
