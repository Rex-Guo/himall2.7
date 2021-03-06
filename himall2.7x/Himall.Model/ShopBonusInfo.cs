//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShopBonusInfo:BaseModel
    {
        public ShopBonusInfo()
        {
            this.Himall_ShopBonusGrant = new HashSet<ShopBonusGrantInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long ShopId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal RandomAmountStart { get; set; }
        public decimal RandomAmountEnd { get; set; }
        public Model.ShopBonusInfo.UseStateType UseState { get; set; }
        public decimal UsrStatePrice { get; set; }
        public decimal GrantPrice { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public System.DateTime BonusDateStart { get; set; }
        public System.DateTime BonusDateEnd { get; set; }
        public string ShareTitle { get; set; }
        public string ShareDetail { get; set; }
        public string ShareImg { get; set; }
        public bool SynchronizeCard { get; set; }
        public string CardTitle { get; set; }
        public string CardColor { get; set; }
        public string CardSubtitle { get; set; }
        public bool IsInvalid { get; set; }
        public Nullable<int> ReceiveCount { get; set; }
        public string QRPath { get; set; }
        public int WXCardState { get; set; }
    
        public virtual ICollection<ShopBonusGrantInfo> Himall_ShopBonusGrant { get; set; }
        public virtual ShopInfo Himall_Shops { get; set; }
    }
}
