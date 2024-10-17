using System;

struct ShoppingCar
{
    public string Name;
    public int Number;
    public double Price;
    public string Currency;
    public int TwdPrice;
}

struct Shop
{
    public string Name;
    public int Number;
}

namespace E94106012_practice_1_2
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ShoppingCar[] shoppingCars = new ShoppingCar[3];
            shoppingCars[0].Name = "潛水相機防丟繩";
            shoppingCars[0].Number = 0;
            shoppingCars[0].Price = 199;
            shoppingCars[0].TwdPrice = 199;
            shoppingCars[1].Name = "潛水配重帶";
            shoppingCars[1].Number = 0;
            shoppingCars[1].Price = 460;
            shoppingCars[1].TwdPrice = 460;
            shoppingCars[2].Name = "潛水作業指北針";
            shoppingCars[2].Number = 0;
            shoppingCars[2].Price = 1100;
            shoppingCars[2].TwdPrice = 1100;

            for (int i = 0; i < shoppingCars.Length; i++)
            {
                shoppingCars[i].Currency = "TWD";
            }

            Shop[] ShopStores = new Shop[3];
            ShopStores[0].Name = "潛水相機防丟繩";
            ShopStores[0].Number = 1;
            ShopStores[1].Name = "潛水配重帶";
            ShopStores[1].Number = 2;
            ShopStores[2].Name = "潛水作業指北針";
            ShopStores[2].Number = 1;

            bool loopdone = true;
            do
            {
                Console.WriteLine("(1)商品列表 (2)新增至購物車 (3)自購物車刪除 (4)查看購物車 (5)結帳 (6)轉換幣值 (7)退出網站"); //螢幕顯示選項
                Console.Write("輸入數字選擇功能 : ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: //(1)商品列表
                        Console.WriteLine("列表:");
                        Console.WriteLine("商品名稱 商品單價");
                        Console.WriteLine("1.潛水相機防丟繩 ({0}){1}", shoppingCars[0].Currency, shoppingCars[0].Price);
                        Console.WriteLine("2.潛水配重帶 ({0}){1}", shoppingCars[1].Currency, shoppingCars[1].Price);
                        Console.WriteLine("3.潛水作業指北針 ({0}){1}", shoppingCars[2].Currency, shoppingCars[2].Price);

                        Console.WriteLine();
                        break;

                    case 2: //(2)新增至購物車
                        int choose, Number;

                        Console.WriteLine("(1)潛水相機防丟繩 (2)潛水配重帶 (3)潛水作業指北針"); //顯示購物選項
                        //---------輸入錯誤---------
                        do
                        {
                            Console.Write("輸入數字選擇商品 : ");
                            choose = Convert.ToInt32(Console.ReadLine());

                            if (choose >= 1 && choose <= 3)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("錯誤!請重新輸入!\n");
                            }
                        } while (true);

                        //---------正確輸入---------
                        do
                        {
                            Console.Write("輸入數量 : ");
                            Number = Convert.ToInt32(Console.ReadLine());

                            if (Number >= 1 && Number <= 5)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("錯誤!請重新輸入!\n");
                            }
                        } while (true);

                        shoppingCars[choose - 1].Number += Number;

                        Console.WriteLine();
                        break;

                    case 3: //(3)自購物車刪除
                        int Del_Choose, Del_Number;

                        Console.WriteLine("購物車內容:");
                        Console.WriteLine("商品 單價 數量 小計");
                        Console.WriteLine("1.{0} ({1}){2} {3} {4}", shoppingCars[0].Name, shoppingCars[0].Currency, shoppingCars[0].Price, shoppingCars[0].Number, shoppingCars[0].Number * shoppingCars[0].Price);
                        Console.WriteLine("2.{0} ({1}){2} {3} {4}", shoppingCars[1].Name, shoppingCars[1].Currency, shoppingCars[1].Price, shoppingCars[1].Number, shoppingCars[1].Number * shoppingCars[1].Price);
                        Console.WriteLine("3.{0} ({1}){2} {3} {4}", shoppingCars[2].Name, shoppingCars[2].Currency, shoppingCars[2].Price, shoppingCars[2].Number, shoppingCars[2].Number * shoppingCars[2].Price);

                        //---------輸入錯誤---------
                        do
                        {
                            Console.Write("輸入數字選擇商品 : ");
                            Del_Choose = Convert.ToInt32(Console.ReadLine());

                            if (Del_Choose >= 1 && Del_Choose <= 3)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("錯誤!請重新輸入!\n");
                            }
                        } while (true);

                        //---------輸入正確---------
                        do
                        {
                            Console.Write("輸入數量 : ");
                            Del_Number = Convert.ToInt32(Console.ReadLine());

                            if (Del_Number >= 0 && Del_Number <= shoppingCars[Del_Choose - 1].Number)
                            {
                                shoppingCars[Del_Choose - 1].Number -= Del_Number;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("輸入錯誤!請重新輸入!\n");
                            }
                        } while (true);
                        Console.WriteLine("成功刪除!");

                        Console.WriteLine();
                        break;
                    case 4:  // (4)查看購物車
                        Console.WriteLine("購物車內容:");
                        Console.WriteLine("商品 單價 數量 小計");
                        Console.WriteLine("1.{0} ({1}){2} {3} {4}", shoppingCars[0].Name, shoppingCars[0].Currency, shoppingCars[0].Price, shoppingCars[0].Number, shoppingCars[0].Number * shoppingCars[0].Price);
                        Console.WriteLine("2.{0} ({1}){2} {3} {4}", shoppingCars[1].Name, shoppingCars[1].Currency, shoppingCars[1].Price, shoppingCars[1].Number, shoppingCars[1].Number * shoppingCars[1].Price);
                        Console.WriteLine("3.{0} ({1}){2} {3} {4}", shoppingCars[2].Name, shoppingCars[2].Currency, shoppingCars[2].Price, shoppingCars[2].Number, shoppingCars[2].Number * shoppingCars[2].Price);
                        Console.WriteLine();
                        break;

                    case 5:  // (5)結帳
                        double sum = 0;  // 總價

                        Console.WriteLine("訂單商品:");
                        Console.WriteLine("商品 單價 數量 小計");

                        foreach (ShoppingCar sc in shoppingCars)
                        {
                            if (sc.Number != 0)
                            {
                                Console.WriteLine("{0} ({1}){2} {3} {4}",
                                    sc.Name, sc.Currency, sc.Price, sc.Number, sc.Number * sc.Price);

                                sum += sc.Number * sc.Price;
                            }
                        }

                        Console.WriteLine("總價 = {0}", sum);

                        // 結帳

                        Console.Write("*是否要結帳(Y/N)*:");
                        string decision = Console.ReadLine();

                        if (decision == "Y")
                        {
                            bool CheckStore = true;  // true=庫存足夠

                            for (int i = 0; i < shoppingCars.Length; i++)
                            {
                                if (shoppingCars[i].Number > ShopStores[i].Number)
                                {
                                    Console.WriteLine("{0}庫存不足!剩餘數量{1}!", ShopStores[i].Name, ShopStores[i].Number);
                                    CheckStore = false;
                                }
                            }

                            if (CheckStore)
                            {
                                Console.Write("*選擇結帳方式(1.線上支付 2.貨到付款):");  // 結帳方式
                                string paid = Console.ReadLine();
                                if (paid != "1" && paid != "2")
                                {
                                    Console.WriteLine("輸入錯誤!請重新輸入!\n");
                                    break;
                                }

                                Console.Write("*折扣碼(若無折扣碼則輸入N):");  // 折扣碼
                                string discount = Console.ReadLine();
                                if (discount != "N" && discount != "1111")
                                {
                                    Console.WriteLine("輸入錯誤!請重新輸入!\n");
                                    break;
                                }

                                Console.WriteLine("\n訂單狀態:");
                                Console.WriteLine("商品 單價 數量 小計");
                                foreach (ShoppingCar sc in shoppingCars)
                                {
                                    if (sc.Number != 0)
                                    {
                                        Console.WriteLine("{0} ({1}){2} {3} {4}",
                                           sc.Name, sc.Currency, sc.Price, sc.Number, sc.Number * sc.Price);

                                        sum += sc.Number * sc.Price;
                                    }
                                }

                                Console.WriteLine("總價 = {0}", sum);
                                if (discount == "1111")
                                {
                                    Console.WriteLine("總價(折扣後) = {0}", sum * 0.95);
                                }

                                Console.WriteLine("狀態:{0}", paid == "1" ? "已付款" : "尚未付款");
                                loopdone = false;
                                break;

                            }
                        }
                        else if (decision == "N")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("輸入錯誤!請重新輸入!\n");
                            break;
                        }

                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("選擇貨幣 1.TWD 2.USD 3.CNY 4.JPY :");
                        changeCurrency(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 7:
                        loopdone = false;
                        break;

                    default:
                        Console.WriteLine("錯誤!請重新輸入!\n");
                        continue;

                }
            } while (loopdone);

            void changeCurrency(string currency_type)
            {
                switch (currency_type)
                {
                    case "1":
                        for (int i = 0; i < shoppingCars.Length; i++)
                        {
                            shoppingCars[i].Price = shoppingCars[i].TwdPrice;
                            shoppingCars[i].Currency = "TWD";
                        }

                        break;

                    case "2":
                        if (shoppingCars[0].Currency != "TWD")
                        {
                            changeCurrency("1");
                        }

                        for (int i = 0; i < shoppingCars.Length; i++)
                        {
                            shoppingCars[i].Price *= 0.031;
                            shoppingCars[i].Currency = "USD";
                        }

                        break;

                    case "3":
                        if (shoppingCars[0].Currency != "TWD")
                        {
                            changeCurrency("1");
                        }

                        for (int i = 0; i < shoppingCars.Length; i++)
                        {
                            shoppingCars[i].Price *= 0.23;
                            shoppingCars[i].Currency = "CNY";
                        }

                        break;

                    case "4":
                        if (shoppingCars[0].Currency != "TWD")
                        {
                            changeCurrency("1");
                        }

                        for (int i = 0; i < shoppingCars.Length; i++)
                        {
                            shoppingCars[i].Price *= 4.59;
                            shoppingCars[i].Currency = "JPY";
                        }

                        break;

                }
            }
        }
    }
}
