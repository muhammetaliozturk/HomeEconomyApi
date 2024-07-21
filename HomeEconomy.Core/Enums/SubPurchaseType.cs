namespace HomeEconomyApi.Core.Enums
{
    public enum SubPurchaseType
    {
        Bim = 1,
        Hakmar = 2,
        TarimKredi = 3,
        Firin = 4,
        SokAndA101 = 5,
        GroceryStore = 6,
        OtherMarkets = 7,

        Gasoline = 8,
        CarCare = 9,
        Insurance = 10,
        
        LCWaikiki = 11,
        EBebek = 12,
        OtherShops = 13,

        Hepsiburada = 14,
        Trendyol = 15,
        Youtube = 16,
        Netflix = 17,
        Steam = 18,
        OtherWebsites = 19,

        Hospital = 20,
        Pharmacy = 21,
        OtherHealthIssues = 22,

        EatOut = 23,
        ParkingLot = 24,
        Present = 25,
        VariousOther = 26
    }

    public static class SubPurchaseTypeText
    {
        public static string GetText(SubPurchaseType SubPurchaseType)
        {
            string text;

            switch (SubPurchaseType)
            {
                case SubPurchaseType.Bim:
                    text = "BİM";
                    break;

                case SubPurchaseType.Hakmar:
                    text = "Hakmar";
                    break;

                case SubPurchaseType.TarimKredi:
                    text = "Tarım KK";
                    break;

                case SubPurchaseType.Firin:
                    text = "Fırın";
                    break;

                case SubPurchaseType.SokAndA101:
                    text = "Şok-A101";
                    break;

                case SubPurchaseType.GroceryStore:
                    text = "Bakkal";
                    break;

                case SubPurchaseType.OtherMarkets:
                    text = "Diğer Market";
                    break;

                case SubPurchaseType.Gasoline:
                    text = "Benzin";
                    break;

                case SubPurchaseType.CarCare:
                    text = "Araç Bakım";
                    break;

                case SubPurchaseType.Insurance:
                    text = "Sigorta";
                    break;

                case SubPurchaseType.LCWaikiki:
                    text = "LC Waikiki";
                    break;

                case SubPurchaseType.EBebek:
                    text = "EBebek";
                    break;

                case SubPurchaseType.OtherShops:
                    text = "Diğer Mağaza";
                    break;

                case SubPurchaseType.Hepsiburada:
                    text = "Hepsiburada";
                    break;

                case SubPurchaseType.Trendyol:
                    text = "Trendyol";
                    break;

                case SubPurchaseType.Youtube:
                    text = "Youtube";
                    break;

                case SubPurchaseType.Netflix:
                    text = "Netflix";
                    break;

                case SubPurchaseType.Steam:
                    text = "Steam";
                    break;

                case SubPurchaseType.OtherWebsites:
                    text = "Diğer Siteler";
                    break;

                case SubPurchaseType.Hospital:
                    text = "Hastane";
                    break;

                case SubPurchaseType.Pharmacy:
                    text = "Eczane";
                    break;

                case SubPurchaseType.OtherHealthIssues:
                    text = "Diğer Sağlık";
                    break;

                case SubPurchaseType.EatOut:
                    text = "Dışarıda Yemek";
                    break;

                case SubPurchaseType.ParkingLot:
                    text = "Otopark";
                    break;

                case SubPurchaseType.Present:
                    text = "Hediye vb.";
                    break;

                case SubPurchaseType.VariousOther:
                    text = "Diğer Çeşitli";
                    break;

                default:
                    text = "";
                    break;
            }

            return text;
        }
    }
}
