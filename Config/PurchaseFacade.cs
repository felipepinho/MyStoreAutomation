using MyStoreAutomation.Data;
using MyStoreAutomation.Pages.AdressPage;
using MyStoreAutomation.Pages.CartPage;
using MyStoreAutomation.Pages.CheckoutPage;
using MyStoreAutomation.Pages.LoginPage;
using MyStoreAutomation.Pages.PaymentPage;
using MyStoreAutomation.Pages.ProductPage;
using MyStoreAutomation.Pages.ShippingPage;
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

        private AdressPage AdressPage => GetPages<AdressPage>();
        private CartPage CartPage => GetPages<CartPage>();
        private CheckoutPage CheckoutPage => GetPages<CheckoutPage>();
        private LoginPage LoginPage => GetPages<LoginPage>();
        private PaymentPage PaymentPage => GetPages<PaymentPage>();
        private ProductPage ProductPage => GetPages<ProductPage>();
        private ShippingPage ShippingPage => GetPages<ShippingPage>();

        public void PurchaseProduct(string product, ClientInfo clientInfo)
        {
            ProductPage.NavigateTo(product);
            ProductPage.AddToCartButton();
            CartPage.ProceedToCheckoutButton();
            CheckoutPage.ProceedToCheckoutButton();
            LoginPage.ClientInput(clientInfo);
            LoginPage.SignInButton();
            AdressPage.ProceedToCheckoutButton();
            ShippingPage.TermsOfServiceCheck();
            ShippingPage.ProceedToCheckoutButton();
            PaymentPage.PaymentButton(clientInfo);
        }
    }
}
