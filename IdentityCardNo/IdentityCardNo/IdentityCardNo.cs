using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdentityCardNo
{
    class IdentityCardNo
    {
        private static IdentityCardNo instance = null;
        String no;
        private IdentityCardNo() { }
        public static IdentityCardNo getInstance() 
        {
            if (instance == null)
            {
                instance = new IdentityCardNo();
                instance.setIdentityCardNo("440804199601090145");
            }
            return instance;
        }
        private void setIdentityCardNo(String no)
        {
            this.no = no;
        }
        public String getIdentityCardNo() 
        {
            return no;
        }
    }
}
