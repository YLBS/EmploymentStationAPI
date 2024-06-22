using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class FinTradeList
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public int DptId { get; set; }
        public decimal TradeMoney { get; set; }
        public decimal ReceiveMoney { get; set; }
        public string? Info { get; set; }
        public byte ReceiveFlag { get; set; }
        public int TradeEplId { get; set; }
        public DateTime TradeDate { get; set; }
        public int ReceiveEplId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime InputDate { get; set; }
        public short? NewType { get; set; }
        public bool DelFlag { get; set; }
        public int? OtherFinId { get; set; }
        public int? ProvId { get; set; }
        public int? CityId { get; set; }
        /// <summary>
        /// 1招聘；2软件；3猎才(前端)；4猎才(后端)
        /// </summary>
        public int TradeListType { get; set; }
    }
}
