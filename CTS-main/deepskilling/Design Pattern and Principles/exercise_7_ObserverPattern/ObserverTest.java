public class ObserverTest {

    public static void main(String[] args) {

        StockMarket stockMarket =
                new StockMarket();

        Observer mobile =
                new MobileApp();

        Observer web =
                new WebApp();

        stockMarket.registerObserver(mobile);

        stockMarket.registerObserver(web);

        System.out.println(
                "Stock price changed to 1000");

        stockMarket.setStockPrice(1000);

        System.out.println();

        System.out.println(
                "Stock price changed to 1200");

        stockMarket.setStockPrice(1200);

    }

}
