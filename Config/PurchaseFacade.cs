using MyStoreAutomation.Data;
using MyStoreAutomation.Pages.AdressPage;
using MyStoreAutomation.Pages.CartPage;
using MyStoreAutomation.Pages.CheckoutPage;
using MyStoreAutomation.Pages.LoginPage;
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
        private CartPage CartPage => GetPages<CartPage>();
        private CheckoutPage CheckoutPage => GetPages<CheckoutPage>();
        private LoginPage LoginPage => GetPages<LoginPage>();
        private AdressPage AdressPage => GetPages<AdressPage>();

        public void PurchaseProduct(string product, string productPrice, ClientInfo clientInfo)
        {
            ProductPage.Navigate(product);
            ProductPage.AddToCartButton();
            CartPage.ProceedToCheckoutButton();
            CheckoutPage.ProceedToCheckoutButton();
            LoginPage.ClientInput(clientInfo);
            LoginPage.SignInButton();
            AdressPage.ProceedToCheckoutButton();
        }
    }
}
