using System;

namespace 初试
{


    //1.创建员工对象并赋值，使用无参构造。
    //2.定义并使用有参构造方法创建对象
    //3.使用初始化器创建对象
    class Empoyee
    {
        public String EmpId;
        public String Name;
        public String PassWord;
        public String Department;
        public DateTime Birthday;

        //无参
        public Empoyee()
        {
            Console.WriteLine("无参构建");
        }

        //有参
        public Empoyee(string name, string password, string department, string empid, DateTime birthday)
        {
            this.Name = name;
            this.PassWord = password;
            this.Department = department;
            this.EmpId = empid;
            this.Birthday = birthday;
        }

    }

    //三角面积
    class Triangle
    {
        public double a;
        public double b;
        public double c;

        public double GetS()
        {
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
    }

    class Program
    {
        // 猜拳 随机数
        public static int Round()
        {
            Random r = new Random();
            int num = r.Next(0, 3);
            return num;
        }

        //猜拳 胜负
        private static void IsWin(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("平局");
            }
            else if ((a == 0 && b == 1) || (a == 1 && b == 2) || (a == 2 && b == 0))
            {
                Console.WriteLine("你赢了");
            }
            else
            {
                Console.WriteLine("你输了");
            }
            IsWhat(a, "玩家出");
            IsWhat(b, "电脑出");
        }

        //猜拳 出拳
        private static void IsWhat(int sum, string name)
        {
            switch (sum)
            {
                case 0:
                    Console.WriteLine(name + "剪刀");
                    break;
                case 1:
                    Console.WriteLine(name + "包袱");
                    break;
                case 2:
                    Console.WriteLine(name + "锤头");
                    break;
            }
        }

        static void Main(string[] args)
        {

            //猜拳
            Console.WriteLine("--------------------");
            Console.WriteLine("0 剪刀\n1 包袱\n2 锤头\n3 退出");
            Console.WriteLine("--------------------");

            int num;
            do
            {
                Console.WriteLine("\n机器人已出拳");
                Console.WriteLine("请出拳...");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        IsWin(num, Round());
                        break;
                    case 1:
                        IsWin(num, Round());
                        break;
                    case 2:
                        IsWin(num, Round());
                        break;
                    case 3:
                        Console.WriteLine("游戏已退出");
                        break;
                    default:
                        Console.WriteLine("请正确输入!");
                        break;
                }
            } while (num != 3);

            //三角面积
            Triangle tri = new Triangle();
            Console.WriteLine("请输入边1");
            tri.a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入边2");
            tri.b = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入边3");
            tri.c = int.Parse(Console.ReadLine());
            Console.WriteLine(tri.GetS());




            //string a = Console.ReadLine();
            //Jusic(a);
            ////第一题
            ///*方法一*/
            //Console.WriteLine("*********************************" +
            //    "\n        欢迎来到C#编程世界" +
            //    "\n*********************************");

            ///*方法二*/
            //Console.WriteLine("*********************************");
            //Console.WriteLine("        欢迎来到C#编程世界");
            //Console.WriteLine("*********************************");

            ////第二题
            //Console.WriteLine("小明说:\"2\\3\\5都是素数\"");

            ////第三题
            ///*方法一*/
            //Console.WriteLine("                    购物清单");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("商品名称     购买数量     商品价格     金额");
            //Console.WriteLine("padMp4       2            400          800");
            //Console.WriteLine("汉飞燕鼠标   1            120          120");

            ///*方法二*/
            //Console.WriteLine("                    购物清单" +
            //    "\n--------------------------------------------" +
            //    "\n商品名称     购买数量     商品价格     金额" +
            //    "\npadMp4       2            400          800" +
            //    "\n汉飞燕鼠标   1            120          120");

            //定义姓名张三。年龄20，成绩95三个变量，并在控制台输出
            //string name = "张三";
            //int age = 20;
            //double score = 95;
            //Console.WriteLine("姓名："+name+"\n年龄："+age+"\n成绩："+score);

            //从控制台输入一个名字，在名字后追加三个字”你很棒”
            //再接收从控制台输入的年龄和成绩进行输出
            //Console.WriteLine("请输入名字:");
            //string Name = Console.ReadLine();
            //Console.WriteLine("请输入年龄:");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入成绩:");
            //Double Score = Double.Parse(Console.ReadLine());
            //Console.WriteLine(Name +"你很棒"+"\n年龄：" + Age + "\n成绩：" + Score );

            //从控制台获取一个天数， 计算此天数对应的周数和剩余的天数
            //Console.WriteLine("请输入天数:");
            //int days = int.Parse(Console.ReadLine());
            //int zhou = days / 7;
            //int tian = days % 7;
            //Console.WriteLine("当前第"+zhou+"周\n"+"剩余"+tian+"天");

            //输入华氏度double，输出对应的摄氏度；公式--摄氏度=5.0/9 *（华氏度-32）
            //Console.WriteLine("请输入华氏度:");
            //double hs = double.Parse(Console.ReadLine());
            //double ss = 5.0 / 9 * (hs-32);
            //Console.WriteLine("华氏度："+hs+"\n摄氏度："+ss);

            //李四这次考了 80 分，请输入学员张三的考试成绩
            //并判定张三的成绩是否比李四的成绩高

            //Console.WriteLine("请输入张三的成绩：");
            //int zs = int.Parse(Console.ReadLine());
            //Boolean isHigh = zs > 80;
            //Console.WriteLine("张三的成绩是否比李四高:"+isHigh);

            //某航空公司征召飞行员的条件是视力超过 1.6,身高在 160 厘米和 170 厘米之间
            //请编写代码模拟应征者是否符合飞行员的过程
            //Console.WriteLine("请输入视力：");
            //double sl = double.Parse(Console.ReadLine());
            //Console.WriteLine("请输入身高：");
            //int sg = int.Parse(Console.ReadLine());
            //Boolean isTrue = (sl>1.6) && (sg>=160&&sg<=170);
            //Console.WriteLine("是否被录取:" + isTrue);

            //输入一个年份判定，此年份是否是闰年。
            //闰年的判定的规则是 能被 4 整数,但不能被 100 整除，或者能被 400 整除
            //Console.WriteLine("请输入年份：");
            //int year = int.Parse(Console.ReadLine());
            //Boolean isYear = (year%4==0&&year%100!=0)||(year%400==0);
            //Console.WriteLine("是否是闰年:" + isYear);

            //输入一个 100 到 999 之间的数字，如果各位数字的立方和等于这个数字本
            //则此数字就是水仙花数。编写一个程序，判定输入数字是否是水仙花数。
            //Console.WriteLine("请输入一个数字：");
            //int num = int.Parse(Console.ReadLine());
            //int g = num % 100%10;
            //int s = num % 100 / 10;
            //int b = num / 100;
            //Boolean isNum = (g*g*g+s*s*s+b*b*b)==num;
            //Console.WriteLine("输入的是否是水仙花数:" + isNum);


            //Console.WriteLine("输入性别");
            //string sex = Console.ReadLine();
            //Console.WriteLine("输入距离");
            //double jl = double.Parse(Console.ReadLine());
            //if (sex=="男")
            //{
            //    Console.WriteLine(123);
            //}

            //Console.WriteLine("输入收入:");
            //double sr = double.Parse(Console.ReadLine());
            //if (sr<=15000)
            //{
            //    sr = sr - (sr*0.05);
            //}else if (sr>15000&&sr<=30000)
            //{
            //    sr =sr-(sr*0.15);
            //}
            //else if (sr > 30000 && sr <= 60000)
            //{
            //    sr = sr - (sr * 0.35);
            //}
            //else if (sr > 60000 && sr <= 100000)
            //{
            //    sr = sr - (sr * 0.65);
            //}
            //else
            //{
            //    sr = sr - (sr * 0.15);
            //}

            //任务1：
            //某航空公司征召飞行员的条件是
            //视力超过 1.6，身高在 160 厘米和 170 厘米之间，
            //当符合条件时，输出： 恭喜你被录取了，并赠送大红花。
            //当不符合条件时，输出：还是去学习C#吧
            //Console.WriteLine("请输入视力：");
            //double sl = double.Parse(Console.ReadLine());
            //Console.WriteLine("请输入身高:");
            //int sg = int.Parse(Console.ReadLine());
            //if ((sl > 1.6) && (sg >= 160 && sg <= 170))
            //{
            //    Console.WriteLine("恭喜你被录取了，并赠送大红花");
            //}
            //else
            //{
            //    Console.WriteLine("还是去学习C#吧");
            //}

            //任务2：
            //学生成绩等级评定
            //>= 90  优秀
            //>= 80  良好
            //>= 60  中等
            //< 60   极差

            //Console.WriteLine("请输入成绩:");
            //int cj = int.Parse(Console.ReadLine());
            //if (cj >= 90)
            //{
            //    Console.WriteLine("优秀");
            //}
            //else if (cj >= 80)
            //{
            //    Console.WriteLine("良好");
            //}
            //else if (cj >= 60)
            //{
            //    Console.WriteLine("中等");
            //}
            //else
            //{
            //    Console.WriteLine("渣渣");
            //}

            //任务3：
            //大家拨打移动客服电话 10086 时，会提示：
            //归属地、套餐服务请按 1；优惠活动请按 2；
            //停复机手机上网及密码服务请按 3；增值业务预定请按 4；
            //无线宽带业务请按 5；人工服务请按 0，
            //现在请使用 C#代码，模拟用户如果按下某个数字键，转入执行相关业务。
            //Console.WriteLine("请输入按键:");
            //string num = Console.ReadLine();
            //switch (num)
            //{
            //    case "0":
            //        Console.WriteLine("人工服务");
            //        break;
            //    case "1":
            //        Console.WriteLine("归属地、套餐服务");
            //        break;
            //    case "2":
            //        Console.WriteLine("优惠活动");
            //        break;
            //    case "3":
            //        Console.WriteLine("停复机手机上网及密码服务");
            //        break;
            //    case "4":
            //        Console.WriteLine("增值业务预定");
            //        break;
            //    case "5":
            //        Console.WriteLine("无线宽带业务");
            //        break;
            //    default:
            //        Console.WriteLine("输入有误");
            //        break;
            //}

            //任务4：
            //输入一个年份和月份，输出这个月份的天数。
            //分析： 1、 3、 5、 7、 8、 10、 12 都是 31 天；
            //4、 6、 9、 11 都是 30 天，而 2 月要分是否闰年。
            //可以选择 switch结构。

            //Console.WriteLine("请输入年份:");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入月份:");
            //int th = int.Parse(Console.ReadLine());
            //switch (th)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine(31 + "天");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine(30 + "天");
            //        break;
            //    case 2:
            //        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //        {
            //            Console.WriteLine(29 + "天");
            //        }
            //        else
            //        {
            //            Console.WriteLine(28 + "天");
            //        }
            //        break;
            //}

            //任务5：
            //用 C# 描述一个小盆友参加中招体育考试中的铅球项目测试，
            //输出相应的分数。 评判标准如下：
            //性别   10    9       8        7        6        5 
            //男    >=9  8.2-9  7.5-8.2  6.5-7.5  5.5-6.5    <5.5
            //女    >=8  7-8      6-7      5-6     4.2-5     <4.2

            //Console.WriteLine("请输入性别:");
            //string sex = Console.ReadLine();
            //Console.WriteLine("请输入距离:");
            //double jl = double.Parse(Console.ReadLine());
            //if (sex=="男")
            //{
            //    if (jl>=9)
            //    {
            //        Console.WriteLine(10);
            //    }
            //    else if (jl>=8.2)
            //    {
            //        Console.WriteLine(9);
            //    }
            //    else if (jl>=7.5)
            //    {
            //        Console.WriteLine(8);
            //    }
            //    else if (jl>=6.5)
            //    {
            //        Console.WriteLine(7);
            //    }
            //    else if (jl>=5.5)
            //    {
            //        Console.WriteLine(6);
            //    }
            //    else
            //    {
            //        Console.WriteLine(5);
            //    }
            //}
            //else if(sex=="女")
            //{
            //    if (jl >= 8)
            //    {
            //        Console.WriteLine(10);
            //    }
            //    else if (jl >= 7)
            //    {
            //        Console.WriteLine(9);
            //    }
            //    else if (jl >= 6)
            //    {
            //        Console.WriteLine(8);
            //    }
            //    else if (jl >= 5)
            //    {
            //        Console.WriteLine(7);
            //    }
            //    else if (jl >= 4.2)
            //    {
            //        Console.WriteLine(6);
            //    }
            //    else
            //    {
            //        Console.WriteLine(5);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}

            //任务6：
            //超市的商品进行优惠打折，购买物品的金额越多折扣越大
            //购买商品的总价小于 200 元不打折，达到 200 元打 9 折
            //达到 500 元时打 8.5 折，达到 1000 元打 8 折。请输入商品的总金额
            //然后输出实际应付金额。 
            //Console.WriteLine("请输入商品总价格:");
            //double sum = double.Parse(Console.ReadLine());
            //double sums = 0;
            //if (sum>=1000)
            //{
            //    sums = sum*0.8;
            //}else if (sum>=500)
            //{
            //    sums = sum * 0.85;
            //}
            //else if (sum >= 200)
            //{
            //    sums = sum * 0.9;
            //}
            //else
            //{
            //    sums = sum * 1;
            //}
            //Console.WriteLine("实际应付："+sums+"元");

            //int i = 1;
            //while (i <= 8000)
            //{
            //    if (i == 444)
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine("请输入总人数:");
            //int num = int.Parse(Console.ReadLine());
            //int i = 1;
            //double sum = 0;
            //while (i <= num)
            //{
            //    Console.WriteLine("第"+i+"名学生成绩" );
            //    double cj = double.Parse(Console.ReadLine());
            //    if (cj < 0)
            //    {
            //        Console.WriteLine("---录入出错---");
            //        continue;
            //    }
            //    sum += cj;
            //    i++;
            //}
            //double avg = sum / num;
            //Console.WriteLine("总成绩：" + sum + "\n平均值" + avg);

            //用C#程序模拟刷题8000道（练习while循环）；
            //A:刷到第444道不会，不想刷了；放弃（练习break）；
            //B:刷到第444道不会，还想刷，跳过这一题，继续刷完（练习continue）

            //A:
            //int i = 1;
            //while (i <= 8000)
            //{
            //    if (i == 444)
            //    {
            //        Console.WriteLine("太难了，不刷了(硬气)!");
            //        break;
            //    }
            //    Console.WriteLine("第" + i + "道");
            //    i++;
            //}

            ////B:
            //int j = 1;
            //while (j <= 8000)
            //{
            //    if (j == 444)
            //    {
            //        Console.WriteLine("不会，下一道!");
            //        j++;
            //        continue;
            //    }
            //    Console.WriteLine("第" + j + "道");
            //    j++;
            //}

            //某次C#考试结束后，录入班级人数和学员成绩，计算班级学员的平均成绩
            //一旦分数录入为负，提示录入错误，并重新录入该学员成绩（练习while循环）
            //Console.WriteLine("请输入总人数:");
            //int num = int.Parse(Console.ReadLine());
            //int r = 1;
            //double sum = 0;
            //while (r <= num)
            //{
            //    Console.WriteLine("第" + r + "名学生成绩");
            //    double cj = double.Parse(Console.ReadLine());
            //    if (cj < 0)
            //    {
            //        Console.WriteLine("---录入出错---");
            //        continue;
            //    }
            //    sum += cj;
            //    r++;
            //}
            //double avg = sum / num;
            //Console.WriteLine("总成绩：" + sum + "\n平均值" + avg);

            //利用 do-while 循环结构，构建一种循环菜单模式。
            //Console.WriteLine("*****菜单*****");
            //Console.WriteLine("退出\t0\n进货\t1\n销售\t2\n盘点\t3");
            //Console.WriteLine("**************");
            //int key;
            //do
            //{
            //    Console.WriteLine("请输入操作编号:");
            //    key = int.Parse(Console.ReadLine());
            //    switch (key)
            //    {
            //        case 0:
            //            Console.WriteLine("退出");
            //            break;
            //        case 1:
            //            Console.WriteLine("进货");
            //            break;
            //        case 2:
            //            Console.WriteLine("销售");
            //            break;
            //        case 3:
            //            Console.WriteLine("盘点");
            //            break;
            //        default:
            //            Console.WriteLine("没有此编号");
            //            break;
            //    }
            //} while (key != 0);

            //计算整数 1 到 100 之间，所有既能被 3 整除，又能被 5 整除的数字之和。
            //int d = 0;
            //for (int c = 1; c <= 100; c++)
            //{
            //    if ((c % 3 == 0) && (c % 5 == 0))
            //    {
            //        d += c;
            //    }
            //}
            //Console.WriteLine("既能被 3 整除,又能被 5 整除的数字之和为" + d);

            //输出6行8列的矩形；练习循环嵌套
            //for (int e = 1; e <= 6; e++)
            //{
            //    for (int f = 1; f <= 8; f++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}



            //////九九乘法表
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + "*" + i + "=" + (j * i) + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //////等腰
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 7; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (int j = i - 1; j >= 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //////棱形
            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 7; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (int j = i - 1; j >= 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 7; i >= 1; i--)
            //{
            //    for (int j = 7; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (int j = i - 1; j >= 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //////平行四边形
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //////百钱百鸡
            //for (int g = 0; g <= 20; g++)
            //{
            //    for (int m = 0; m <= 34; m++)
            //    {
            //        for (int x = 0; x <= 100; x++)
            //        {
            //            if ((g + m + x == 100) && (g * 5 + m * 3 + x / 3 == 100) && (x % 3 == 0))
            //            {
            //                Console.WriteLine("公鸡:" + g + "母鸡:" + m + "小鸡:" + x);
            //            }
            //        }
            //    }
            //}

            //////公司500亿
            //double sr = 100;
            //int year = 2009;
            //while (sr <= 500)
            //{
            //    sr = sr * (1.25);
            //    year++;
            //}
            //Console.WriteLine(year + "年收入为" + sr + "亿");

            //////小球落地
            //double h = 100;
            //for (int i = 1; i <= 10; i++)
            //{
            //    h /= 2;
            //}
            //Console.WriteLine(h);

            //////猴子吃桃
            //int t = 1;
            //for (int i = 1; i < 10; i++)
            //{
            //    t = (t + 1) * 2;
            //}
            //Console.WriteLine(t);

            //////猜数字
            //int unum;
            //int i = 1;
            //Random r = new Random();
            //int num = r.Next(1, 100);
            //Console.WriteLine("叮咚!数字已生成，请输入你猜测的数字");
            //do
            //{
            //    if (i > 6)
            //    {
            //        Console.WriteLine("挑战失败");
            //        break;
            //    }
            //    Console.WriteLine("-------------第" + i + "次挑战-------------");
            //    unum = int.Parse(Console.ReadLine());
            //    if (unum == num)
            //    {
            //        Console.WriteLine("恭喜你,猜对啦!");
            //        break;
            //    }
            //    else if (unum > num)
            //    {
            //        Console.WriteLine("高了");
            //    }
            //    else if (unum < num)
            //    {
            //        Console.WriteLine("低了");
            //    }
            //    i++;
            //} while (unum != -1);

            //定义数组
            ////--1.空间定义--
            //int[] a = new int[10];
            //double[] b = new double[5];
            //--2.初始化--
            //string[] strs = {"河南","河北","上海","湖北"};
            //Console.WriteLine(strs[3]);
            //strs[3] = "湖北1";
            //Console.WriteLine(strs.Length);
            //for (int i=0;i<strs.Length;i++)
            //{
            //    Console.WriteLine(strs[i]);
            //}
            //foreach (string item in strs)
            //{
            //    Console.WriteLine(item);
            //}



            //    //1.录入班级人数并根据班级人数录入学生的成绩到一个数组中，求出平均分数。（练习foreach遍历数组）
            //    Console.WriteLine("输入班级人数:");
            //    int num = int.Parse(Console.ReadLine());
            //    double[] sco = new double[num];
            //    double sum = 0;
            //    for (int i = 0; i < sco.Length; i++)
            //    {
            //        Console.WriteLine("第" + (i + 1) + "个学生成绩:");
            //        sco[i] = double.Parse(Console.ReadLine());
            //    }
            //    foreach (double scos in sco)
            //    {
            //        sum += scos;
            //    }
            //    Console.WriteLine("总成绩:" + sum + "平均值:" + (sum / num));

            //    //2.录入班级人数并根据班级人数录入学生的成绩到一个数组中，求出最大值。（练习for遍历数组）
            //    Console.WriteLine("输入班级人数:");
            //    int num = int.Parse(Console.ReadLine());
            //    double[] sco = new double[num];
            //    double sum = 0;
            //    for (int i = 0; i < sco.Length; i++)
            //    {
            //        Console.WriteLine("第" + (i + 1) + "个学生成绩:");
            //        sco[i] = double.Parse(Console.ReadLine());
            //        sum += sco[i];
            //    }
            //    Console.WriteLine("总成绩:" + sum + "平均值:" + (sum / num));

            //    //没有返回值;没有参数的方法  输出hello  world   void    方法名首字母大写
            //    Program.PrintHello();
            //    ///PS:下面的写在类(class)里面,而不是Main()里面,与Main()平级
            //    private static void PrintHello()
            //    {
            //        Console.WriteLine("hello world");
            //    }

            //    //求两个整数的和  有参数  有返回值  int  方法名首字母大写
            //    int sum = GetSum(10, 20);
            //    Console.WriteLine(sum);
            //    ///PS:下面的写在类(class)里面,而不是Main()里面,与Main()平级
            //    private static int GetSum(int a, int b)
            //    {
            //        int sum = a + b;
            //        return sum;
            //    }

            //    //3.将第一题（求出平均分数），第二题（求出最大值）分别封装成方法调用。
            //    double[] score = GetAry();
            //    Console.WriteLine("平均值" + GetAvg(score) + "最大值:" + GetMax(score));
            //    ///PS:下面的写在类(class)里面,而不是Main()里面,与Main()平级
            //    private static double[] GetAry()
            //    {
            //        Console.WriteLine("输入班级人数:");
            //        int num = int.Parse(Console.ReadLine());
            //        double[] sco = new double[num];
            //        for (int i = 0; i < sco.Length; i++)
            //        {
            //            Console.WriteLine("第" + (i + 1) + "个学生成绩:");
            //            sco[i] = double.Parse(Console.ReadLine());
            //        }
            //        return sco;
            //    }

            //    private static double GetAvg(double[] sco)
            //    {
            //        double sum = 0;
            //        for (int i = 0; i < sco.Length; i++)
            //        {
            //            sum += sco[i];
            //        }
            //        double avg = sum / sco.Length;
            //        return avg;
            //    }

            //    private static double GetMax(double[] sco)
            //    {
            //        double max = sco[0];
            //        for (int i = 0; i < sco.Length; i++)
            //        {
            //            if (sco[i] > max)
            //            {
            //                max = sco[i];
            //            }
            //        }
            //        return max;
            //    }

            //    //4.编写一个方法可以交换两个 int 变量的值。
            //    int a = 2, b = 4;
            //    int c;
            //    Console.WriteLine("交换后:" + "\na:" + a + "b:" + b);
            //    c = a;
            //    a = b;
            //    b = c;
            //    Console.WriteLine("交换后:" + "\na:" + a + "b:" + b);

            //    //5.返回指定日期的开始点和结束点。比如指定日期是 2012 / 2 / 8，传递给方法 GetBeginEndTime
            //    //得到 开始点 2012 / 2 / 8 0:0:0 结束点 2012 / 2 / 8 23:59:59。 
            //    DateTime time = new DateTime(2012, 2, 8);
            //    DateTime begin, end;
            //    GetBeginEndTime(time, out begin, out end);
            //    Console.WriteLine("开始时间：" + begin + "\n结束时间:" + end);
            //    /// PS:下面的写在类(class)里面,而不是Main()里面,与Main()平级
            //    private static void GetBeginEndTime(DateTime time, out DateTime begin, out DateTime end)
            //{
            //    begin = new DateTime(time.Year, time.Month, time.Day, 0, 0, 0);
            //    end = new DateTime(time.Year, time.Month, time.Day, 23, 59, 59);
            //}

            //    //6.定义一个 Power 方法， 用来计算指定值 X 的指定次方 N，如果 N 没有明确指定，则默认值为 2，并编写测试代码。 
            //    double Pow = GetPower(3, 4);
            //    Console.WriteLine(Pow);
            //    ///PS:下面的写在类(class)里面,而不是Main()里面,与Main()平级
            //    private static double GetPower(int a, int b = 2)
            //    {
            //        double Pow = Math.Pow(a, b);
            //        return Pow;
            //    }

            //    //7.定义一个方法，接收三个数，要求实现求出最大值。并在Main()方法中调用测试
            //Console.WriteLine(GetMax(-20, 10, 10));
            ///PS:下面的写在类(class)里面,而不是Main()里面,与Main()平级
            //private static int GetMax(int a, int b, int c)
            //{
            //    int max = a;
            //    if (a < b)
            //    {
            //        max = b;
            //    }
            //    if (max < c)
            //    {
            //        max = c;
            //    }
            //    return max;
            //}



            ////获取输入的年份year
            //Console.WriteLine("请输入年份:");
            //int year = int.Parse(Console.ReadLine());
            ////获取输入的月份month
            //Console.WriteLine("请输入月份:");
            //int month = int.Parse(Console.ReadLine());
            ////调用方法得到输入的年月距1900年1月的天数并输出
            //int SumDays = GetSumDays(year, month);
            //Console.WriteLine("{0}年{1}月距离1900年1月1日有{2}天", year, month, SumDays);
            //Console.WriteLine("星期日\t星期一\t星期二\t星期三\t星期四\t星期五\t星期六");
            ////判断某月的1号是星期几兵放到对应上面"星期"的位置
            //int week = SumDays % 7 + 1;
            //if (week != 7)
            //{
            //    for (int i = 1; i <= week; i++)
            //    {
            //        Console.Write("\t");
            //    }
            //}
            ////获取输入的月份的天数,并打印出来，如果碰到周六则换行
            //int MonthDays = GetMonth(year, month);
            //for (int i = 1; i <= MonthDays; i++)
            //{
            //    Console.Write("{0}\t", i);
            //    if ((SumDays + i) % 7 == 6)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            //int[] arr = { '1', '2', '3', 'a', 'b' };
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(arr[i] + ", ");
            //}


            //1.创建员工对象并赋值，使用无参构造。
            //2.定义并使用有参构造方法创建对象
            //3.使用初始化器创建对象
            //任务拓展：定义一个描述三角形的类 Triangle，要求如下：
            //3、 根据海伦公式计算三角形的面积。
            //海伦公式： 假设在平面内，有一个三角形，边长分别为 a、 b、 c，那么三角形的面积 S 可由海伦公式求得：
            //S=Math.sqrt(p*(p-a)(p-b)(p-c)) 注：公式里的 p 为半周长： p=(a+b+c)/2




            //1.定义结构体要使用 struct 关键字，现在我们定义一个学员信息的结构体Student。
            //包含三个成员变量（学号StuCode 生日Birthday  姓名Name）
            //一个方法（一个 GetAge 的方法，根据出生日期来来获取一个年龄）。
            //在Main方法中使用 Student来创建变量，并读写其中（结构体是复合类型）的值，调用方法完成测试。
            //Student stu = new Student();
            //stu.Name = "张三";
            //stu.Birthday = DateTime.Parse("2000.08.27");
            //stu.StuCode = "001";
            //Console.WriteLine("姓名:{0}\n生日:{1}\n学号:{2}\n年龄:{3}", stu.Name, stu.Birthday, stu.StuCode, stu.GetAge());

            //1.创建员工对象并赋值，使用无参构造。
            //2.定义并使用有参构造方法创建对象
            //3.使用初始化器创建对象
            //Empoyee emp = new Empoyee();
            //emp.Name = "张三";
            //emp.PassWord = "123456";
            //emp.EmpId = "001";
            //emp.Department = "人事部";
            //emp.Birthday = DateTime.Parse("1980.01.01");
            //Console.WriteLine("姓名:{0}\n密码:{1}\n工号:{2}\n部门:{3}\n生日:{4}", emp.Name, emp.PassWord, emp.EmpId, emp.Department, emp.Birthday);
            ////Empoyee emp1 = new Empoyee("王五", "123456", "003", "人事部", DateTime.Parse("1998.1.1"));
            ////Console.WriteLine("姓名:{0}\n密码:{1}\n工号:{2}\n部门:{3}\n生日:{4}", emp.Name, emp.PassWord, emp.EmpId, emp.Department, emp.Birthday);



        }

        //1.定义结构体要使用 struct 关键字，现在我们定义一个学员信息的结构体Student。
        //包含三个成员变量（学号StuCode 生日Birthday  姓名Name）
        //一个方法（一个 GetAge 的方法，根据出生日期来来获取一个年龄）。
        //在Main方法中使用 Student来创建变量，并读写其中（结构体是复合类型）的值，调用方法完成测试
        struct Student
        {
            public string StuCode;
            public DateTime Birthday;
            public string Name;

            public int GetAge()
            {
                int Age = DateTime.Now.Year - Birthday.Year;
                return Age;
            }
        }


        //判断是否是闰年
        //public static bool IsR(int year)
        //{
        //    bool isR;
        //    if (year % 100 != 0 && year % 4 == 0 || year % 400 == 0)
        //    {
        //        isR = true;
        //    }
        //    else
        //    {
        //        isR = false;
        //    }
        //    return isR;
        //}

        ////某年的天数
        //public static int GetYear(int year)
        //{
        //    int years = 0;
        //    if (IsR(year))
        //    {
        //        years = 366;
        //    }
        //    else
        //    {
        //        years = 365;
        //    }
        //    return years;
        //}

        ////某年某月的天数
        //public static int GetMonth(int year, int month)
        //{
        //    int months = 0;
        //    switch (month)
        //    {
        //        case 1:
        //        case 3:
        //        case 5:
        //        case 7:
        //        case 8:
        //        case 10:
        //        case 12:
        //            months = 31;
        //            break;
        //        case 4:
        //        case 6:
        //        case 9:
        //        case 11:
        //            months = 30;
        //            break;
        //        case 2:
        //            if (IsR(year))
        //            {
        //                months = 29;
        //            }
        //            else
        //            {
        //                months = 28;
        //            }
        //            break;
        //    }
        //    return months;
        //}

        ////距离1900/1/1的天数
        //public static int GetSumDays(int year, int month)
        //{
        //    int SumDays = 0;
        //    for (int i = 1900; i < year; i++)
        //    {
        //        SumDays += GetYear(i);
        //    }
        //    for (int j = 1; j < month; j++)
        //    {
        //        SumDays += GetMonth(year, j);
        //    }
        //    return SumDays;
        //}


        //private static double[] GetAry()
        //{
        //    Console.WriteLine("输入班级人数:");
        //    int num = int.Parse(Console.ReadLine());
        //    double[] sco = new double[num];
        //    for (int i = 0; i < sco.Length; i++)
        //    {
        //        Console.WriteLine("第" + (i + 1) + "个学生成绩:");
        //        sco[i] = double.Parse(Console.ReadLine());
        //    }
        //    return sco;
        //}

        //private static double GetAvg(double[] sco)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < sco.Length; i++)
        //    {
        //        sum += sco[i];
        //    }
        //    double avg = sum / sco.Length;
        //    return avg;
        //}

        //private static double GetMax(double[] sco)
        //{
        //    double max = sco[0];
        //    for (int i = 0; i < sco.Length; i++)
        //    {
        //        if (sco[i] > max)
        //        {
        //            max = sco[i];
        //        }
        //    }
        //    return max;
        //}

    }
}
