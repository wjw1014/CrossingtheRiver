using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myProject
{

      //=====================================
      //  作者：JayveeWong
      //  时间：2019-05-13 14:30:26
      //  文件名：Form1.cs
      //  版本：V2.0.1  
      //  说明： 
      //=====================================

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <m_fun>
        /// 创建mfunslist列表，用于存放可行方案
        /// </m_fun>
         List<mfun> m_fun = new List<mfun>(100);

        /// <summary>
        /// index  正在计算的方案索引
        /// numpass  可行方案的数量
        /// mcount  野人/传教士的渡河人数
        /// </summary>
        int index = 0;
        int numpass = 0;
        // 传教士数量
        int c_count = 0;
        // 野人数量
        int y_count = 0;
        string str = "";

        static int chuan = 2;

        /// <click button>
        /// 开始计算渡河方案 —— 按钮
        /// </click button>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            m_fun.Clear();
            index = 0;
            numpass = 0;
            c_count = 0;
            y_count = 0;
            chuan = 2;
            str = "";
            richTextBox1.Text = "此程序仅仅实现计算效过，寻找出所有可执行方案，并未进行优化。\n因此当计算数据过大时，会造成程序停止响应，不用担心，程序依旧在后台运算。\n当程序使用足够时间运行完毕后，程序将会重新响应并展示所有的可行方案！\n计算需要一定的时间，请耐心等待···\n\n\t\t\t\t\t\tby Jayvee";
            
            // 判断用户选择渡河人数是否正确
            if (ccount.Value <= 0 && upcount.Value <= 0)
            {
                MessageBox.Show("error：请输入正确的渡河人数!");
                return;
            }
            else
            {
                if (ccount.Value > 3 || upcount.Value > 3)
                {
                    if (MessageBox.Show("warning:【警告】此运算人数过多，预计可执行方案过大，计算过程中将占用大量CPU造成系统卡顿，界面暂停服务至计算完成重新恢复，过程不可正常中止，是否继续计算？", "重要提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        // 传教士个数
                        c_count = int.Parse(ccount.Value.ToString());
                        // 野人个数
                        y_count = int.Parse(ccount.Value.ToString());
                        // 设置船的最大载客量
                        chuan = int.Parse(upcount.Value.ToString());
                        mfun m = new mfun();
                        m_fun.Add(m);
                        // 设置左岸传教士人数
                        m_fun[index].left_c = c_count;
                        // 设置左岸野人数量
                        m_fun[index].left_y = y_count;
                        // 右边传教士人数
                        m_fun[index].right_c = 0;
                        // 右边野人数量
                        m_fun[index].right_y = 0;
                        // 船的位置
                        m_fun[index].boat_location = 1;
                        // 调用递归算法
                        mCalculation(m_fun[index]);
                    }
                    else
                    {
                        richTextBox1.Text = "计算终止";
                        return;
                    }
                }
                else
                {
                    // 传教士个数
                    c_count = int.Parse(ccount.Value.ToString());
                    // 野人个数
                    y_count = int.Parse(ccount.Value.ToString());
                    // 设置船的最大载客量
                    chuan = int.Parse(upcount.Value.ToString());
                    mfun m = new mfun();
                    m_fun.Add(m);
                    // 设置左岸传教士人数
                    m_fun[index].left_c = c_count;
                    // 设置左岸野人数量
                    m_fun[index].left_y = y_count;
                    // 右边传教士人数
                    m_fun[index].right_c = 0;
                    // 右边野人数量
                    m_fun[index].right_y = 0;
                    // 船的位置
                    m_fun[index].boat_location = 1;
                    // 调用递归算法
                    mCalculation(m_fun[index]);
                }
            }

            richTextBox1.Text = "一共计算出 " + numpass + " 条度河方案\n" + str;
        }

        /// <summary>
        /// 递归算法
        /// </summary>
        /// <returns></returns>
        public int mCalculation(mfun m)
        {
            // 是否达到渡河目标状态
            if (m.right_c == c_count && m.right_y == y_count)
            {
                // 找到第numpass条渡河方案
                numpass++;
                str += "\n\t方案" + numpass + "：\n\t\t左传\t左野\t右传\t右野\t船\n";
                // 循环遍历每个方案的每个步骤
                for (int i = 0; i <= index; i++)
                {
                    str += "\t\t" + m_fun[i].left_c + "\t" + m_fun[i].left_y + "\t" + m_fun[i].right_c + "\t" + m_fun[i].right_y + "\t" + m_fun[i].boat_location + "\n";
                    
                }
                return 0;
            }

            // 是否重复操作
            for (int i = 0; i < index; i++)
            {
                if (m.left_c == m_fun[i].left_c && m.left_y == m_fun[i].left_y)
                {
                    if (m.boat_location == m_fun[i].boat_location)
                    {
                        return 0;
                    }
                }
            }

            // 人数是否合理
            if (m.left_c < 0 || m.left_y < 0 || m.right_c < 0 || m.right_y < 0)
            {
                return 0;
            }

            // 传教士的人数是否大于等于野人
            if ((m.left_c < m.left_y && m.left_c != 0) || (m.right_c < m.right_y && m.right_c != 0))
            {
                return 0;
            }

            //渡河中间变量
            mfun mm = new mfun();

           // 递归算法
            for (int cchuan = chuan; cchuan >= 0; cchuan-- )
            {
                for (int ychuan = chuan; ychuan >= 0 ; ychuan--)
                {
                    if ((cchuan >= ychuan && cchuan + ychuan <= chuan && cchuan + ychuan>0) || (cchuan < ychuan && cchuan == 0))
                    {
                        mm.left_c = m.left_c - cchuan * m.boat_location;
                        mm.left_y = m.left_y - ychuan * m.boat_location;
                        mm.right_c = m.right_c + cchuan * m.boat_location;
                        mm.right_y = m.right_y + ychuan * m.boat_location;
                        mm.boat_location = (-m.boat_location);
                        index = index + 1;
                        m_fun.Insert(index, mm);
                        mCalculation(m_fun[index]);
                        index = index - 1;
                    }
                }
            }
                        
            return 0;
        }

        private void 注意事项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此程序仅仅实现计算效过，寻找出所有可执行方案，并未进行优化。\n因此当计算数据过大时，会造成程序停止响应，不用担心，程序依旧在后台运算。\n当程序使用足够时间运行完毕后，程序将会重新响应并展示所有的可行方案！\n计算需要一定的时间，请耐心等待···\n\n\t\t\t\t\t\tby Jayvee");
        }

        private void 结果说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("运算结束会在“渡河方案”内显示有多少套可行方案以及每一套方案的具体渡河步骤。\n 左传：河左岸传教士人数\n左野：河左岸野人人数\n右传：河右岸传教士人数\n右野：河右岸野人人数\n船：船现在的位置（1：:表示船在河的左岸；-1：表示船在河的右岸）\n\n\t\t\t\t\t\tby Jayvee");
        }
    }

    /// <mfun>
    /// 创建mfun类，用于存放渡河其中一个可行方案的每个步骤
    /// </mfun>
    public class mfun
    {
        public int left_c;
        public int right_c;
        public int left_y;
        public int right_y;
        public int boat_location;
    }

}
