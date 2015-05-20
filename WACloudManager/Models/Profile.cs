using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WACloudManager.Models
{
    

    [Serializable]
    public class Domain
    {
        
        public Int16 DomainID { get; set; }


        public String DomainName { get; set; }

        public String CloudAccessPassCode { get; set; }

        public String Contact { get; set; }

        public String ContactPhone { get; set; }


        public String ContactEmail { get; set; }



        public String CompanyName { get; set; }



        public String WACloudServerURL { get; set; }



        public String StorageAccount { get; set; }


        //public String StoragePrimaryAccessKey { get; set; }


        //public String StorageSecondAccessKey { get; set; }


        public String StorageBlobURL { get; set; }


        public String StorageTableURL { get; set; }


        public String StorageQueueURL { get; set; }


        public DateTime? DomainExpireTime { get; set; }


        public Boolean IsActive { get; set; }


        public DateTime? CreateTime { get; set; }


        public DateTime? ModifyTime { get; set; }

    }

    [Serializable]
    public class Account
    {

        public Int16 AccountID { get; set; }


        public Int16 DomainID { get; set; }


        public String UserName { get; set; }


        public String Password { get; set; }


        public String AccountName { get; set; }


        public String AccountEmail { get; set; }


        public String AccountPhone { get; set; }


        public String AccountExpireTime { get; set; }


        public Boolean IsActive { get; set; }


        public DateTime? CreateTime { get; set; }


        public DateTime? ModifyTime { get; set; }


        // public virtual ICollection<Domain> Domains { get; set; }

    }
}