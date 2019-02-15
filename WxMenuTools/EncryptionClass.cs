using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxMenuTools
{
    class EncryptionClass
    {

        /// <summary>
        /// 作用：将字符串内容转化为16进制数据编码，其逆过程是Decode
        /// 参数说明：
        /// strEncode 需要转化的原始字符串
        /// 转换的过程是直接把字符转换成Unicode字符,比如数字"3"-->0033,汉字"我"-->U+6211
        /// 函数decode的过程是encode的逆过程.
        /// </summary>
        public static string EncodeHex(string strEncode)
        {
            string strReturn = "";//  存储转换后的编码
            try
            {
                foreach (short shortx in strEncode.ToCharArray())
                {
                    strReturn += shortx.ToString("X4");
                }
            }
            catch { }
            return strReturn;
        }

        /// <summary>
        /// 作用：将16进制数据编码转化为字符串，是Encode的逆过程
        /// </summary>
        public static string DecodeHex(string strDecode)
        {
            string sResult = "";
            try
            {
                for (int i = 0; i < strDecode.Length / 4; i++)
                {
                    sResult += (char)short.Parse(strDecode.Substring(i * 4, 4),
                        global::System.Globalization.NumberStyles.HexNumber);
                }
            }
            catch { }
            return sResult;
        }

        /// <summary>
        /// 将数字转换成16进制字符串，后两位加入随机字符，其可逆方法为DecodeForNum
        /// </summary>
        public static string EncodeHexForNum(int id)
        {
            //用户加上起始位置后的
            int startUserIndex = id;
            //转换成16进制
            string hexStr = Convert.ToString(startUserIndex, 16);
            //后面两位加入随机数
            string randomchars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string tmpstr = "";

            //整除的后得到的数可能大于被除数
            tmpstr += randomchars[(id / randomchars.Length) > randomchars.Length ? randomchars.Length - 1 : (id / randomchars.Length)];

            //余数不可能大于被除数
            tmpstr += randomchars[(id % randomchars.Length) > randomchars.Length ? randomchars.Length - 1 : (id % randomchars.Length)];

            //返回拼接后的字符，转成大写
            string retStr = (hexStr + tmpstr).ToUpper();

            return retStr;
        }

        /// <summary>
        /// 解密16进制字符串，此方法只适合后面两位有随机字符的
        /// </summary>
        public static int DecodeHexForNum(string strDecode)
        {
            if (strDecode.Length > 2)
            {
                strDecode = strDecode.Substring(0, strDecode.Length - 2);
                return Convert.ToInt32(strDecode, 16);
            }
            return 0;
        }
    }
}
