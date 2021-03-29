using System;

namespace POC.MysqlConnectorEntityFramework
{
    public static class UtilGuid
    {

        public static string FromByteArrayToString(byte[] data)
        {
            try { return new Guid(data).ToString(); } catch { return null; }
        }

        public static byte[] FromStringToByteArray(string data)
        {
            try { return Guid.Parse(data).ToByteArray(); } catch { return null; }
        }

        public static byte[] GenerateGuidByteArray() => Guid.NewGuid().ToByteArray();

        public static byte[] StringGuidToByte(string input)
        {
            Guid.TryParse(input, out Guid output);
            return output.ToByteArray();
        }

    }
}
