namespace HomeEconomyApi.Core.Enums
{
    public enum MainPurchaseType
    {
        Grocery = 1,
        Car = 2,
        Dress = 3,
        Internet = 4,
        Health = 5,
        Other = 6
    }

    public static class MainPurchaseTypeText
    {
        public static string GetText(MainPurchaseType MainPurchaseType)
        {
            string text;

            switch (MainPurchaseType)
            {
                case MainPurchaseType.Grocery:
                    text = "Market";
                    break;

                case MainPurchaseType.Car:
                    text = "Araç";
                    break;

                case MainPurchaseType.Dress:
                    text = "Kıyafet";
                    break;

                case MainPurchaseType.Internet:
                    text = "İnternet";
                    break;

                case MainPurchaseType.Health:
                    text = "Sağlık";
                    break;

                case MainPurchaseType.Other:
                    text = "Diğer";
                    break;

                default:
                    text = "";
                    break;
            }

            return text;
        }
    }
}
