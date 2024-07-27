using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //影片資料集合
            List<Video> videoList = new List<Video>() {
                new Video() { Name = "天竺鼠車車", Country = "日本", Duration = 2.6, Type = "動漫" },
                new Video() { Name = "鬼滅之刃", Country = "日本", Duration = 25, Type = "動漫" },
                new Video() { Name = "鬼滅之刃-無限列車", Country = "日本", Duration = 100, Type = "電影" },
                new Video() { Name = "甜蜜家園SweetHome", Country = "韓國", Duration = 50, Type = "影集" },
                new Video() { Name = "The 100 地球百子", Country = "歐美", Duration = 48, Type = "影集" },
                new Video() { Name = "冰與火之歌Game of thrones", Country = "歐美", Duration = 60, Type = "影集" },
                new Video() { Name = "半澤直樹", Country = "日本", Duration = 40, Type = "影集" },
                new Video() { Name = "古魯家族：新石代", Country = "歐美", Duration = 90, Type = "電影" },
                new Video() { Name = "角落小夥伴電影版：魔法繪本裡的新朋友", Country = "日本", Duration = 77, Type = "電影" },
                new Video() { Name = "TENET天能", Country = "歐美", Duration = 80, Type = "電影" },
                new Video() { Name = "倚天屠龍記2019", Country = "中國", Duration = 58, Type = "影集" },
                new Video() { Name = "下一站是幸福", Country = "中國", Duration = 45, Type = "影集" },
            };

            //人物資料集合
            List<Person> personList = new List<Person>()
            {
                new Person() { Name = "Bill", CountryPrefer = new List<string>() { "中國", "日本" }, TypePrefer = new List<string>() { "影集" } },
                new Person() { Name = "Jimmy", CountryPrefer = new List<string>() { "日本" }, TypePrefer = new List<string>() { "動漫", "電影" } },
                new Person() { Name = "Andy", CountryPrefer = new List<string>() { "歐美", "日本" }, TypePrefer = new List<string>() { "影集", "電影" } },
            };

            //Select 投影 或 投影+索引(.Select((x,idx)=>$"No{ idx + 1 }:{x.Name}") )
            //where 有沒有是不是對不對
            //4.5.6
            //c# languer


            //null 聯合運算子{?. ??如果沒有變成...}

            // ok   1. 找出所有日本的影片名稱
            {
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有日本的影片名稱");
            Console.WriteLine(string.Join(",", videoList.Where((x) => x.Country == "日本").Select(x => x.Name)));
            Console.WriteLine($"{Environment.NewLine}");
            }
            //--------------------------------------------------------------------------------

            // 2. 找出所有歐美的影片且類型為"影集"的影片名稱
            { 
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有歐美的影片且類型為'影集'的影片名稱");
            var video2 = videoList.Where((x) => x.Country == "歐美" && x.Type == "影集").Select(x => x.Name);
            Console.WriteLine(string.Join(",", video2));
            //foreach (var item in video2)
            //{ Console.WriteLine($"{item.Name}"); }
            }
            //--------------------------------------------------------------------------------

            // 3. 是否有影片片長超過120分鐘的影片
            {

            Console.WriteLine($"{Environment.NewLine}Q: 是否有影片片長超過120分鐘的影片");
            bool video3 = videoList.Any((x) => x.Duration > 120 );
            Console.WriteLine (  video3 ? "有!" : "沒有");
            //if (video3)
            //{
            //    Console.WriteLine("有影片片長超過120分鐘的影片");
            //}
            //else
            //{
            //    Console.WriteLine("沒有符合影片片長超過120分鐘的影片");
            //}
            }

            // 4. 請列出所有人的名稱，並且用大寫英文表示，ex: Bill -> BILL
            Console.WriteLine($"{Environment.NewLine}Q: 請列出所有人的名稱，並且用大寫英文表示");

            var pepole = personList
                .Take(personList.Count)
                .Select(x => x.Name
                .ToUpper())
                .ToList();
            Console.WriteLine(string.Join(",", pepole));


            //foreach (var item in pepole)
            //{
            //    Console.WriteLine(item.Name.ToUpper());
            //}

            // 5. 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名，ex: No1: 天竺鼠車車
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名");
            int num = 1;
            var videos5 = videoList
                .OrderByDescending((x) => x.Duration)
                .Select(x => $"No{num++}:{x.Name}")
                .ToList(); //不用tolist
            Console.WriteLine(string.Join(Environment.NewLine, videos5));

            //foreach (var item in videos5)
            //{
            //    num++;
            //    Console.WriteLine($"No{num} : {item.Name}");
            //}


            // 6. 將所有影片進行以"類型"分類，並顯示以下樣式(注意縮排)
            /* 
            動漫:
                天竺鼠車車
                鬼滅之刃*/
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片進行以'類型'分類");

            var list6 = videoList.GroupBy(video=>video.Type).Select(y => new
            { 
                type =y.Key, 
                name =y.Select(z=>z.Name)
            }); //因為要選取igroupinp中z群組中的姓名
            
            var list6_1 = list6.Select(x => $"{x.type}{Environment.NewLine}\t" + string.Join( $"{Environment.NewLine}\t",x.name));

            Console.WriteLine(string.Join(Environment.NewLine, list6_1));
            //var result = videoList.GroupBy((x) => x.Type).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} : ");
            //    foreach (var a in item)
            //    {
            //        Console.WriteLine(a.Name);
            //    }
            //}

            

            // 7. 找到第一個喜歡歐美影片的人
            Console.WriteLine($"{Environment.NewLine}Q: 找到第一個喜歡歐美影片的人");
            var like = personList.Find((x) => x.CountryPrefer.Contains("歐美"));
            Console.WriteLine($"第一個喜歡歐美影片的人是{like.Name}");

            // 8. 找到每個人喜歡的影片(根據國家以及類型)，ex: Bill: 半澤直樹, 倚天屠龍記2019, 下一站是幸福
            Console.WriteLine($"{Environment.NewLine}Q: 找到每個人喜歡的影片");
            var list8 = personList.Select((x) => new
            {
                x.Name,
                vName = videoList.Where(y => x.CountryPrefer.Contains(y.Country) && x.TypePrefer.Contains(y.Type)).Select(z => z.Name)
            });
            var list8_1 = list8.Select((x) => $"{x.Name}：{string.Join("、", x.vName)}");
            Console.WriteLine(string.Join(Environment.NewLine, list8_1));

            // select 規劃新表單， where 篩選條件
            //用國家偏好 去 影片清單內看是否包含

            //錯的
            //var list8_2 = personList.Select((x) => new
            //{
            //    x.Name,
            //    vName = videoList.Where(y => y.Country.Contains(x.CountryPrefer.ToString()) && y.Type.Contains(x.TypePrefer.ToString())).Select(z => z.Name)
            //});
            //  var list8_3 = list8_2.Select((x) => $"{x.Name}：{string.Join("、", x.vName)}");


            //Dictionary<string, List<string>> hobbit = new Dictionary<string, List<string>>(); //建立字典儲存每個人喜歡的影片，其實可以拿掉
            //foreach (var person in personList)
            //{
            //    //從影片清單中，找出符合這個人所偏好的國家和類型的影片。
            //    //對每部符合條件的影片，選擇其名字，然後將這些名字轉換為列表。
            //    var someOneLike = videoList.Where((videos) =>
            //            person.CountryPrefer.Contains(videos.Country) &&
            //            person.TypePrefer.Contains(videos.Type))
            //        .Select((videos) => videos.Name)
            //        .ToList();

            //    hobbit.Add(person.Name, someOneLike);
            //}
            //foreach (var person in hobbit)
            //{
            //    Console.WriteLine($"{person.Key} : {string.Join(",", (person.Value.ToArray()))}");
            //}


            // 9. 列出所有類型的影片總時長，ex: 動漫: 100min
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有類型的影片總時長");

            var videos9 = videoList.GroupBy((x) => x.Type).Select ( x => new 
            { type = x.Key,
              total = x.Select(y=>y.Duration).Sum() });
            var video9_1 = videos9.Select(x => $"{x.type} : {x.total}");
            Console.WriteLine(string.Join(Environment.NewLine,video9_1));

            //foreach (var item in videos9)
            //{
            //    double total = item.Sum((x) => x.Duration);
            //    Console.WriteLine($"{item.Key} : {total}min ");

            //}

            // 10. 列出所有國家出產的影片數量，ex: 日本: 3部
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有國家出產的影片數量");

            var video10 = videoList.GroupBy((x) => x.Country).Select(y => new
            {
                country = y.Key,
                count = y.Select(z => z.Name).Count()
            });
            var video10_1 = video10.Select(x => $"{x.country}：{x.count}部");
            Console.WriteLine (string.Join(Environment.NewLine, video10_1));
            //var video10 = videoList.GroupBy((x) => x.Country);
            //foreach (var item in video10)
            //{

            //    Console.WriteLine($"{item.Key} : {item.Count()}部");
            //}


            Console.ReadLine();
        }
    }
}





