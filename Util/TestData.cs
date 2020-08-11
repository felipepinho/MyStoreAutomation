namespace MyStoreAutomation.Util
{
    public class TestData
    {
        #region Personal Information
        public static readonly string email = Helper.GetValue("username");
        public static readonly string password = Helper.GetValue("password");
        public static readonly string type = Helper.GetValue("type");
        #endregion

        #region Products Information
        public const string blouse = "?id_product=2&controller=product";
        public const string blousePrice = "$27.00";
        #endregion
    }
}
