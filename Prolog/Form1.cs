using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace Prolog
{
    public partial class Form1 : Form
    {
        List<MyQuestion> questionList = new List<MyQuestion>();
        private Stack<MyAnswer> myAnswers = new Stack<MyAnswer>();
        private Dictionary<String, String> description = new Dictionary<string, string>();
        private int currentQuestion = -1;
        private List<String> key = new List<string>()
        {
            "vungdau", "trieuchunga", "trieuchungb"
        };
        private MyProlog prolog;
        private const String prologFilePath = @"..\..\Rules_of_diagnose.pl";
        public Form1()
        {
            InitializeComponent();
            prolog = new MyProlog();
            prolog.LoadFile(prologFilePath);
            // Build List question
            buildListQuestion();
        }
        private void buildListQuestion()
        {
            // 0
            questionList.Add(new MyQuestion("Bạn đau ở đâu?",
                new List<string>() { "Đau ở vùng trán", "Đau ở nửa đầu", "Đau sau mắt",
                "Đau ở dạ dày"}));
            // 1
            questionList.Add(new MyQuestion("Bạn cảm thấy thế nào?",
                new List<string>() { "Đau ở vùng thái dương", "Ù tai", "Ngạt mũi", "Mất ngủ"}));
            // 2
            questionList.Add(new MyQuestion("Một triệu chứng nữa?", new List<string>() { "Đau ở chẩm", "Buồn nôn","Đỏ mắt", "Lo âu" }));

            description.Add("DAUDAUCANGTHANG", "Chẩn đoán: ĐAU ĐẦU DO CĂNG THẲNG \n Thuốc: Indomethacin,Ketorolac,Naproxen...\n" +
                "Phản hồi sinh học: là một kỹ thuật thư giãn giúp bạn kiểm soát cơn đau và căng thẳng.\n" +
                "Liệu pháp hành vi nhận thức: là liệu pháp nói chuyện giúp bạn nhận ra các tình huống gây căng thẳng, lo lắng và căng cơ." +
                "Châm cứu: là một liệu pháp thay thế có thể làm giảm căng thẳng và căng cơ bằng cách sử dụng kim châm vào các vùng cụ thể trên cơ thể.");
            description.Add("DAUNUADAU", "Chẩn đoán: ĐAU NỬA ĐẦU \n Thuốc: sumatriptan, dihydroergotamine, lasmitidan...\n" +
                "Thuốc giảm đau dùng điều trị các cơn đau nửa đầu và giảm bớt các triệu chứng.\n" +
                " Các thuốc thường được sử dụng là thuốc giảm đau kháng viêm NSAIDs, sumatriptan, dihydroergotamine, lasmitidan, thuốc giảm đau opioid, thuốc chống nôn…\n" +
                "Thuốc phòng ngừa có thể được dùng thường xuyên, hàng ngày để giảm bớt mức độ nghiêm trọng hoặc tần suất xuất hiện cơn đau nửa đầu.\n" +
                " Các lựa chọn trong nhóm này gồm thuốc làm hạ huyết áp (như chẹn beta), thuốc chống trầm cảm ba vòng, thuốc chống động kinh (valproate, topiramate)…");
            description.Add("DAUDAUTUNGCUM", "Chẩn đoán: ĐAU ĐẦU TỪNG CỤM \n Thuốc: Triptans, Octreotide, Dihydroergotamine...\n" +
                "Bạn có thể kiểm soát tốt nhức đầu cụm nếu bạn lưu ý vài điều sau:\n"+
                "Ngủ đủ và đúng giờ\n" +
                "Dùng thuốc theo chỉ định của bác sĩ\n" +
                "Hỏi ý kiến bác sĩ của bạn trước khi sử dụng thuốc giảm đau không kê toa\n" +
                "Tái khám đúng hẹn.");
            description.Add("DAUDAUMANTINH", "Chẩn đoán: ĐAU ĐẦU MÃN TÍNH \n Thuốc: serotonin, fluoxetine, atenolol...\n" +
                "Bên cạnh đó, bạn nên thường xuyên ra ngoài và vận động, không nên ngồi một chỗ, đặc biệt là không thức khuya hoặc sử dụng máy tính nhiều giờ.\n" +
                "Không nên làm việc quá sức, gây căng thẳng, hay tạo áp lực lên cơ thể để tránh hiện tượng hay đau đầu\n" +
                "Thiết lập một chế độ ăn uống và sinh hoạt hợp lý, tăng cường ăn các loại rau quả giúp tăng sức đề kháng cho cơ thể.\n");
        }

        private void BindQuestion(int index)
        {
            lbQuestion.Text = questionList[index].Question;
            for (int i = 0; i < questionList[index].Answers.Count; i++)
            {
                RadioButton c = (RadioButton)this.Controls.Find("rd" + (i + 1), true).FirstOrDefault();
                c.Text = questionList[index].Answers[i];
                c.Visible = true;
            }
        }

        private int QuestionControl(int index, String ans)
        {
            int current = -1;
            switch (index)
            {
                case 0:
                    if (ans.Equals("tran") || ans.Equals("saumat") || ans.Equals("daday")) { BindQuestion(1); current = 1; }
                    break;
                case 1:
                    if (ans.Equals("ngatmui") || ans.Equals("thaiduong")) { BindQuestion(2); current = 2; }
                    break;
                case 2:
                    break;
            }
            return current;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            BindQuestion(0);
            pn_start.Visible = false;
            pn_vungdau.Visible = true;
            btn_reset.Visible = false;
            btn_Next.Visible = true;
            btn_Back.Visible = true;
        }
        private String GetResult(String ans)
        {
            if (ans == "Đau ở vùng trán") ans = "tran";
            else if (ans == "Đau ở nửa đầu") ans = "nuadau";
            else if (ans == "Đau sau mắt") ans = "saumat"; 
            else if (ans == "Đau ở dạ dày") ans = "daday";
            else if (ans == "Đau ở vùng thái dương") ans = "thaiduong";
            else if (ans == "Ù tai") ans = "utai";
            else if (ans == "Ngạt mũi") ans = "ngatmui";
            else if (ans == "Mất ngủ") ans = "matngu"; 
            else if (ans == "Đau ở chẩm") ans = "cham";
            else if (ans == "Buồn nôn") ans = "buonnon";
            else if (ans == "Đỏ mắt") ans = "domat";
            else if (ans == "Lo âu") ans = "loau";
            return ans;
        }
        private void reset()
        {
            myAnswers.Clear();
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (rd1.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd1.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd1.Text)); }
            else if (rd2.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd2.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd2.Text)); }
            else if (rd3.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd3.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd3.Text)); }
            else if (rd4.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd4.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd4.Text)); }
 
            if (currentQuestion == -1)
            {
                String query = "";
                String history = "";
                while (myAnswers.Count > 0)
                {
                    MyAnswer ma = myAnswers.Pop();
                    query = key[ma.QuestionIndex] + "('" + ma.Answer + "'), " + query;
                    history = "---------------------------------------------------\r\n" + history;
                    history = "[Q] " + ma.Answer + "\r\n" + history;
                    history = "[A] " + questionList[ma.QuestionIndex].Question + "\r\n" + history;
                }
                query = query.Substring(0, query.Length - 2);
                query = "diagnose(X, " + query + ").";
                try
                {
                    String result = description[prolog.GetResult(query).ToUpper()];
                    MessageBox.Show(result, "Chẩn đoán!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Bạn có muốn xem lại lịch sử không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        history += "System result:\r\n" + result;
                        new frmHistory(history).ShowDialog();
                        btn_reset.Visible = true;
                        btn_Next.Visible = false;
                        btn_Back.Visible = false;
                    }
                    else
                    {
                        btn_reset.Visible = true;
                        btn_Next.Visible = false;
                        btn_Back.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                reset();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            pn_start.Visible = true;
            pn_vungdau.Visible = false;
            lbQuestion.Text = "Chương trình chẩn đoán bệnh đau đầu!!!";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            pn_start.Visible = true;
            pn_vungdau.Visible = false;
            lbQuestion.Text = "Chương trình chẩn đoán bệnh đau đầu!!!";
        }
    }
}
