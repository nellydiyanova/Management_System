namespace Management_System
{
    class Receipt
    {
        public int id_product { get; set; }

        public string warehouse { get; set; }

        public string product_name { get; set; }

        public double sale_price { get; set; }

        public double quantity { get; set; }

        public string full_price { get { return string.Format("{0} лв.", sale_price * quantity); } }
    }
}