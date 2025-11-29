using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public enum EnDataStorageType
    {
        /// <summary>
        /// فایل های کاربر
        /// </summary>
        UserUploaded = 1,

        /// <summary>
        /// فایل بیمه نامه
        /// </summary>
        AdminUploaded_InsurancePolicyFile = 2,

        /// <summary>
        /// فایل چک
        /// </summary>
        AdminUploaded_MoneyCheck = 3,

        /// <summary>
        /// فایل الحاقیه قبلی
        /// </summary>
        AdminUploaded_Previous_Endorsement = 4,

        /// <summary>
        /// فایل بازدید
        /// </summary>
        Visit_File = 5,

        /// <summary>
        /// فایل الحاقیه
        /// </summary>
        AdminUploaded_Endorsement = 6,

        /// <summary>
        /// فایل بیمه نامه
        /// </summary>
        InstallmentCheque = 7
    }
}
