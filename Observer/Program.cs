namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss huhansan = new Boss();

            StockObserver stockObserver = new StockObserver("魏关姹",huhansan);
            NBAObserver nbaObserver = new NBAObserver("易管查",huhansan);

            huhansan.Update += new EventHandler(stockObserver.CloseStockMarket);
            huhansan.Update += new EventHandler(nbaObserver.CloseNBADirectSeeding);

            huhansan.SubjectState = "我胡汉三回来了！";
            huhansan.Notify();
        }
    }
}
