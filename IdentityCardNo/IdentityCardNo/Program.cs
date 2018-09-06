using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdentityCardNo
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentityCardNo identityCard1, identityCard2;
            identityCard1 = IdentityCardNo.getInstance();
            identityCard2 = IdentityCardNo.getInstance();
            Console.WriteLine("identityCard1==identityCard2:" + (identityCard1 == identityCard2));
            String str1 = identityCard1.getIdentityCardNo();
            String str2 = identityCard2.getIdentityCardNo();
            Console.WriteLine("identityCard1的身份证号"+str1);
            Console.WriteLine("identityrard2的身份证号"+str2);
        }
    }
}
