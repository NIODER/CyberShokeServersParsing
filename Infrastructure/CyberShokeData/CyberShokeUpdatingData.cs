namespace CyberShoke.Infrastructure.CyberShokeData
{
    public class CyberShokeUpdatingData : ICyberShokeData
    {
        public string GetJsonData()
        {
            return CyberShokeWebRequest.GetJson();
        }
    }
}
