using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Metro
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Select : Metro.Common.LayoutAwarePage
    {

        static List<String> STATION = new List<String>() { "가능", "가산디지털단지", "간석", "개봉",
			"관악", "광명", "구로", "구일", "군포", "금정", "금천구청", "남영", "노량진", "녹양",
			"녹천", "당정", "대방", "덕계", "덕정", "도봉", "도봉산", "도원", "도화", "독산", "동대문",
			"동두천", "동두천중앙", "동묘앞", "동암", "동인천", "두정", "망월사", "명학", "방학", "배방",
			"백운", "병점", "보산", "봉명", "부개", "부천", "부평", "서동탄", "서울역", "서정리",
			"석계", "석수", "성균관대", "성북", "성환", "세류", "세마", "소사", "소요산", "송내",
			"송탄", "수원", "시청", "신길", "신도림", "신설동", "신이문", "신창", "쌍용", "아산",
			"안양", "양주", "역곡", "영등포", "오류동", "오산", "오산대", "온수", "온양온천", "외대앞",
			"용산", "월계", "의왕", "의정부", "인천", "제기동", "제물포", "종각", "종로3가", "종로5가",
			"주안", "중동", "지제", "지행", "직산", "진위", "창동", "천안", "청량리", "탕정", "평택",
			"풍기", "화서", "회기", "회룡", "강남", "강변", "건대입구", "교대", "구로디지털단지", "구의",
			"까치산", "낙성대", "당산", "대림", "도림천", "동대문역사문화공원", "뚝섬", "문래", "방배",
			"봉천", "사당", "삼성", "상왕십리", "서울대입구", "서초", "선릉", "성수", "신답", "신당",
			"신대방", "신림", "신정네거리", "신천", "신촌", "아현", "양천구청", "역삼", "영등포구청",
			"왕십리", "용답", "용두", "을지로3가", "을지로4가", "을지로입구", "이대", "잠실", "잠실나루",
			"종합운동장", "충정로", "한양대", "합정", "홍대입구", "가락시장", "경복궁", "경찰병원",
			"고속터미널", "구파발", "금호", "남부터미널", "녹번", "대곡", "대청", "대치", "대화", "도곡",
			"독립문", "동대입구", "마두", "매봉", "무악재", "백석", "불광", "삼송", "수서", "신사",
			"안국", "압구정", "약수", "양재", "연신내", "오금", "옥수", "원당", "일원", "잠원",
			"정발산", "주엽", "지축", "충무로", "학여울", "홍제", "화정", "경마공원", "고잔", "공단",
			"과천", "길음", "남태령", "노원", "당고개", "대공원", "대야미", "동작", "명동", "미아",
			"미아삼거리", "반월", "범계", "산본", "삼각지", "상계", "상록수", "선바위", "성신여대입구",
			"수리산", "수유", "숙대입구", "신길온천", "신용산", "쌍문", "안산", "오이도", "이촌", "인덕원",
			"정부과천청사", "정왕", "중앙", "총신대입구(이수)", "평촌", "한대앞", "한성대입구", "혜화",
			"회현", "강동", "개롱", "개화산", "거여", "고덕", "공덕", "광나루", "광화문", "군자",
			"굽은다리", "길동", "김포공항", "답십리", "둔촌동", "마곡", "마장", "마천", "마포", "명일",
			"목동", "발산", "방이", "방화", "상일동", "서대문", "송정", "신금호", "신정", "아차산",
			"애오개", "양평", "여의나루", "여의도", "영등포시장", "오목교", "올림픽공원", "우장산", "장한평",
			"천호", "청구", "행당", "화곡", "고려대", "광흥창", "구산", "녹사평", "대흥", "독바위",
			"돌곶이", "디지털미디어시티", "마포구청", "망원", "버티고개", "보문", "봉화산", "상수", "상월곡",
			"새절", "안암", "역촌", "월곡", "월드컵경기장", "응암", "이태원", "증산", "창신", "태릉입구",
			"한강진", "화랑대", "효창공원앞", "강남구청", "공릉", "광명사거리", "남구로", "남성", "내방",
			"논현", "뚝섬유원지", "마들", "먹골", "면목", "반포", "보라매", "사가정", "상도", "상봉",
			"수락산", "숭실대입구", "신대방삼거리", "신풍", "어린이대공원", "용마산", "이수", "장승배기",
			"장암", "중계", "중곡", "중화", "천왕", "철산", "청담", "하계", "학동", "강동구청",
			"남한산성입구", "단대오거리", "모란", "몽촌토성", "문정", "복정", "산성", "석촌", "송파",
			"수진", "신흥", "암사", "장지", "가양", "개화", "공항시장", "구반포", "국회의사당", "노들",
			"등촌", "마곡나루", "사평", "샛강", "선유도", "신논현", "신목동", "신반포", "신방화",
			"양천향교", "염창", "증미", "흑석", "개포동", "경원대", "구룡", "대모산입구", "미금", "보정",
			"서현", "수내", "야탑", "오리", "이매", "정자", "죽전", "태평", "한티", "간석오거리",
			"갈산", "경인교대입구", "계산", "계양", "국제업무지구", "귤현", "동막", "동수", "동춘",
			"문학경기장", "박촌", "부평구청", "부평삼거리", "부평시장", "선학", "센트럴파크", "신연수",
			"예술회관", "원인재", "인천대입구", "인천시청", "인천터미널", "임학", "작전", "지식정보단지",
			"캠퍼스타운", "테크노파크", "구리", "국수", "덕소", "도농", "도심", "망우", "서빙고", "신원",
			"아신", "양수", "양원", "양정", "오빈", "용문", "운길산", "원덕", "응봉", "중랑", "팔당",
			"한남", "가좌", "곡산", "금릉", "금촌", "능곡", "문산", "백마", "수색", "운정", "월롱",
			"일산", "탄현", "파주", "풍산", "행신", "화전", "검암", "운서", "공항화물청사", "인천국제공항",
			"가평", "갈매", "강촌", "굴봉산", "금곡", "김유정", "남춘천", "대성리", "마석", "백양리",
			"사릉", "상천", "청평", "춘천", "퇴계원", "평내호평" };

        List<string> plist = new List<string>();

        public Select()
        {
            this.InitializeComponent();
            plist = STATION;
            SuggestList.ItemsSource = plist;
        }


        async private void GetPositionByAddress(string Address)
        {
            //http://apis.daum.net/local/geo/addr2coord?apikey=DAUM_LOCAL_DEMO_APIKEY&q=%EB%8C%80%ED%95%99%EB%A1%9C&output=json
            //http://dna.daum.net/apis/local/geo/addr2coord
            HttpClient hc = new HttpClient();
            var res = await hc.GetAsync(new Uri("http://apis.daum.net/local/geo/addr2coord?apikey=200144fae82575a21821d764cfe7b3dc9de453d9&q="+Address+"&output=json"));
            var st = await res.Content.ReadAsStringAsync();
            var s = JsonObject.Parse(st);
            //start_address.Text = s["name1"].GetString() + " " + s["name2"].GetString() + " " + s["name3"].GetString();
        }
        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (q.Text == "")
                plist = STATION;
            else
            {
                plist = STATION.FindAll(n => n.Contains(q.Text));
                if (q.Text.Length == 1 && (q.Text.ToCharArray()[0] - 0xac00) / (21 * 28)==-53)
                {
                    //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 
                    //ㄱㄲㄴㄷㄸㄹㅁㅂㅃㅅ ㅆㅇ ㅈ ㅉ ㅊ ㅋ ㅌ ㅍ ㅎ
                    int i=new int();
                    switch((q.Text.ToCharArray()[0]) - 12592){
                        case 1:
                            i=0;
                            break;
                        case 2:
                            i=1;break;
                        case 4:
                            i=2;break;
                        case 7:
                            i=3;break;
                        case 8:
                            i=4;break;
                        case 9:
                            i=5;break;
                        case 17:
                            i=6;break;
                        case 18:
                            i=7;break;
                        case 20:
                            i=8;break;
                        case 21:
                            i=9;break;
                        case 22:
                            i=10;break;
                       case 23:
                            i=11;break;
                        case 24:
                            i=12;break;
                        case 25:
                            i=13;break;
                        case 26:
                            i=14;break;
                        case 27:
                            i=15;break;
                        case 28:
                            i=16;break;
                        case 29:
                            i=17;break;
                        case 30:
                            i=18;break;
                    }
                    plist = STATION.FindAll(
                        n => 
                            (((n.ToCharArray()[0])- 0xac00) / (21 * 28))
                            ==
                            i) ;
                }
                
            }
            SuggestList.ItemsSource = plist;
        }

        private void SuggestList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            this.Frame.GoBack();
            //this.Frame.Navigate(typeof(MainPage));
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached. The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter == "start")
                pageTitle.Text = "출발장소 선택";
            else
                pageTitle.Text = "도착장소 선택";
        }
    }
}
