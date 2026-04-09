namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        // 총 결제 금액을 저장할 전역 변수
        int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // 현재 사용하지 않는 이벤트 핸들러
        }

        // '초기화' 버튼 클릭 시 실행되는 이벤트
        private void btnlnit_Click(object sender, EventArgs e)
        {
            lblTotalCost.ForeColor = Color.LightSkyBlue; // 다시 파란색으로 복구
            lblTotalCost.Font = new Font(lblTotalCost.Font.FontFamily, 16, FontStyle.Regular); // 원래 크기(예: 9pt)로 복구
            // 모든 선택 요소(라디오버튼, 체크박스) 해제
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            rdoHamBurger.TabStop = true;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 주문 목록 리스트박스와 합계 금액 초기화
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.Text = "총 금액: 0원";
        }

        // '주문하기' 버튼 클릭 시 실행되는 이벤트
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 메뉴 미선택 시 처리
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 먼저\n" + "선택해주세요!";
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Font = new Font(lblTotalCost.Font.FontFamily, 11, FontStyle.Bold);
                lstOrder.Items.Clear();
                return;
            }

            // 정상 주문 로직 시작
            lblTotalCost.ForeColor = Color.LightSkyBlue; // 다시 파란색으로 복구
            lblTotalCost.Font = new Font(lblTotalCost.Font.FontFamily, 16, FontStyle.Regular); // 원래 크기(예: 9pt)로 복구
            
            // 버튼을 누를 때마다 중복 합산을 방지하기 위해 초기화 후 재계산
            totalCost = 0;
            lstOrder.Items.Clear();

            // 1. 메인 메뉴 선택 확인 (라디오버튼: 하나만 선택 가능)
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // 2. 사이드 및 추가 옵션 확인 (체크박스: 다중 선택 가능)
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            // 3. 최종 금액 표시 (ToString("N0")를 사용하여 세 자리마다 콤마 추가)
            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";
        }

        private void rdoHamBurger_KeyDown(object sender, KeyEventArgs e)
        {

        }

        // 라디오 버튼들의 KeyDown 이벤트에 연결하세요
        //private void rdoBurger_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Space)
        //    {
        //        RadioButton rdo = sender as RadioButton;
        //        if (rdo != null)
        //        {
        //            // 모든 라디오 버튼을 일단 해제 (AutoCheck가 False이므로 수동 제어)
        //            rdoHamBurger.Checked = false;
        //            rdoBulgogiBurger.Checked = false;
        //            rdoChickenBurger.Checked = false;

        //            // 현재 스페이스바를 누른 버튼만 선택
        //            rdo.Checked = true;

        //            // 실시간 업데이트 호출
        //            btnOrder_Click(sender, e);
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}