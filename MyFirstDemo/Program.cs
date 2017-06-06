using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDemo  // 命名空间
{
    class Program // 类
    {
        static void Main(string[] args) // Main方法程序入口
        {
            Console.WriteLine("Hello world !"); // 命令以分号结束， Ctrl + F5直接运行
            Console.WriteLine("Hello 你好 !");
            // C#的常量
            const string CITY = "布宜诺斯艾利斯";//常量，城市
            const string NAME = "列奥波尔多·福图纳托·加尔铁里·卡斯特利";//常量，姓名
            Console.WriteLine(CITY + "出生在" + NAME + "的一个工人家庭");//使用常量
            // C#的变量
            string hobby;//声明变量保存爱好
            hobby = "剑道";//给爱好变量赋值
            Console.WriteLine("我爱好" + hobby);//打印变量
            // 算法——交换
            string boy = "秀丽";//男孩名字
            string girl = "伟强";//女孩名字
            string temp;//中间变量
            temp = boy;//把男孩的名字赋值给temp
            boy = girl;//把女孩的名字赋值给男孩
            girl = temp;//把temp中的名字赋值给女孩
            Console.WriteLine("男孩叫" + boy + " 女孩叫" + girl);
            // 编程练习
            string today;//今天的午饭
            string tomorrow;//明天的午饭
            today = "鱼香肉丝";
            tomorrow = "小鸡炖蘑菇";
            //请在这里补充代码，实现变量today和tomorrow的交换
            string temp1;
            temp1 = tomorrow;
            tomorrow = today;
            today = temp1;
            //打印
            Console.WriteLine("我今天吃{0}，明天吃{1}。", today, tomorrow); // 顺序的交换
            // 打印结果: 今天吃小鸡炖蘑菇，明天吃鱼香肉丝
            // 数据类型
            string name = "曹少钦";//姓名，string类型
            char sex = '男';//性别，char类型
            int age = 19;//年龄，int类型
            double height = 1.72;//身高，double类型
            Console.WriteLine("我叫{0}，是{1}生，今年{2}岁，身高{3}米。", name, sex, age, height);

            //C#的类型转换
            double d = 2.5;
            int x = (int)(d + 1);
            Console.WriteLine(x);
            // C#标识符的命名规则
            int _num1 = 5;//第一个加数
            int _num2 = 7;//第二个加数
            int sum = _num1 + _num2;//求和
            Console.WriteLine("和是{0}", sum);//打印结果

            // 创建2.0分支
            // 创建jin2.0分支

            // C#中没有boolean这种数据类型,
            // double型的2.3赋值给int型变量i，double型精度高，无法自动转换为int类型
            Console.WriteLine((double)3);
            Console.WriteLine((int)3.6);
            Console.WriteLine((double)3.6);  // 这里转换是多余的！
            // 命名规范--B项int my age错误在变量名中包含了空格 C项 int static错误在用关键字作变量名 D项 int 3th错误在用数字作为变量名开头 

            // C#的算术运算符（一） 加减乘除
            double salary = 6000.00;//基本工资
            double prize = 3200.00;//奖金
            double tax = 4500.00;//交税
            Console.Write("我的工资奖金总额是{0}元", salary + prize);
            Console.WriteLine("我的税后收入是{0}元", salary + prize - tax);
            // C#的算术运算符（二） 取余运算符。
            int year = 2015;//年份
            Console.WriteLine(year % 4);//求年份除以4的余数
            // C#的算术运算符（三） ++ --
            int x1 = 5;
            int y = 5;
            int z = 5;
            x1++;
            Console.Write(x1);
            Console.Write(y++);
            Console.Write(z++);
            Console.WriteLine(++z);  // 输出结果为6557
            // C#的比较运算符                         
            double a = 3.5;
            int b = 3;
            Console.WriteLine((int)a >= b);  // 结果是True

            // C#的逻辑运算符（一）
            Console.WriteLine(true || false);//输出True
            Console.WriteLine(true && false);//输出False
            Console.WriteLine(!false);//输出True

            // C#的逻辑运算符（二）
            int age1 = 4;//年龄
            if (age1 < 6 || age1 > 60)
                Console.WriteLine("请坐爱心座！");
            else
                Console.WriteLine("请坚持一下！");

            int s = 1;
            int t = 3;
            Console.WriteLine(!(s > t));  // 没有！s这样的写法

            // C#的赋值运算符
            double x2, y2;
            x2 = y2 = 2;//从右向左赋值，x、y的值都是2
            x2 /= 0.5;
            y2 -= 2;
            Console.WriteLine(x2 - y2);

            // C#的运算符优先级
            int q = 1;
            Console.WriteLine(++q * q);   // 输出是4（因为++q即q = q + 1，为2，2*2 = 4,这一点要特别注意！
            bool w = ++q * q > 3; // w = True
            bool e = w;//请赋值

            Console.WriteLine(w == e);
            // 条件结构
            double xx = 13.9, yy = 24.4;
            double sum1 = xx + yy;
            double avg = sum1 / 2;
            Console.WriteLine(avg);
            // C#中判断和分支
            int score = 96;//分数
            if (score > 95)//判断
            {//分支1
                Console.WriteLine("奖励一辆自行车");
            }
            // C#中if...else条件结构
            int age2 = 17;//年龄
            if (age2 >= 18)//条件，bool类型
            {//分支1
                Console.WriteLine("你是成年人");
            }
            else
            {//分支2
                Console.WriteLine("你是小盆友");
            }
            double price = 4388;//手机的售价
            double salary1 = 4978.67;//本月实发工资
            if (salary1 >= price)
            {

                Console.WriteLine("可以买到手机");
            }
            else
            {
                Console.WriteLine("屌丝,加油吧! ! !");
            }
            // C#中嵌套的if结构
            char sexq = '男';//性别
            int ageq = 21;//年龄
            if (sexq != '男')//请填写条件
            {
                if (ageq >= 20)
                {
                    Console.WriteLine("达到法定婚龄啦");
                }
                else
                {
                    Console.WriteLine("没有达到哟");
                }
            }
            else
            {
                if (ageq >= 22)
                {
                    Console.WriteLine("达到法定婚龄!");
                }
                else
                {
                    Console.WriteLine("没有达到!");
                }
            }
            // C#中多重if结构
            string job = "科员";
            if (job == "局长")
            {
                Console.WriteLine("发双黄月饼");
            }
            else if (job == "处长")
            {
                Console.WriteLine("发蛋黄月饼");
            }
            else if (job == "科长")
            {
                Console.WriteLine("发枣泥月饼");
            }
            else
            {
                Console.WriteLine("发五仁月饼");
            }
            // C#中else与if的匹配
            int m = 5;
            int n = 6;
            if (m >= n)
            {
                if (m >= 5)
                    Console.WriteLine("5");
            }
            else
            {
                if (n >= 6)
                    Console.WriteLine("6");
                else
                    Console.WriteLine("7");
            }

            double money = 60000.00;//存款金额
            //请在这里补充多重条件判断
            if (money >= 100000)
            {
                Console.WriteLine("送一台微波炉");
            }
            else if (money >= 50000 && money < 100000)
            {
                Console.WriteLine("送一套茶具");
            }
            else if (money >= 10000 && money < 50000)
            {
                Console.WriteLine("送一袋大米");
            }
            else if (money < 10000)
            {
                Console.WriteLine("没有礼品");
            }
            // C#的条件运算符
            int yearz = 2015;//年份
            //请填写代码
            string text;
            text = yearz % 4 == 0 ? "闰年" : "平年";
            Console.WriteLine("今年是{0}", text);
            // C#的switch结构
            string job1 = "处长";//职务
            switch (job1)
            {
                case "局长": Console.WriteLine("发双黄月饼"); break;
                case "处长": Console.WriteLine("发蛋黄月饼"); break;
                case "科长": Console.WriteLine("发枣泥月饼"); break;
                default: Console.WriteLine("发五仁月饼"); break;
            }
            // C#中，可以用 while 循环结构来实现
            int yx = 5;
            while (yx >= 1)//请输入
            {
                Console.Write(yx + " ");
                yx--;//请输入

            }
        }
    }
}
