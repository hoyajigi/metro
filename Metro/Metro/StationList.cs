﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    class Stations
    {
        public List<StationList> Station = new List<StationList>();
        
        public Stations()
        {
        // 1호선
		Station.Add(new StationList("가능", "1", "1907"));
		Station.Add(new StationList("가산디지털단지", "1", "1702"));
		Station.Add(new StationList("간석", "1", "1816"));
		Station.Add(new StationList("개봉", "1", "1801"));
		Station.Add(new StationList("관악", "1", "1705"));
		Station.Add(new StationList("광명", "1", "1750"));
		Station.Add(new StationList("구로", "1", "1701"));
		Station.Add(new StationList("구일", "1", "1813"));
		Station.Add(new StationList("군포", "1", "1709"));
		Station.Add(new StationList("금정", "1", "1708"));
		Station.Add(new StationList("금천구청", "1", "1703"));
		Station.Add(new StationList("남영", "1", "1002"));
		Station.Add(new StationList("노량진", "1", "1004"));
		Station.Add(new StationList("녹양", "1", "1908"));
		Station.Add(new StationList("녹천", "1", "1021"));
		Station.Add(new StationList("당정", "1", "1729"));
		Station.Add(new StationList("대방", "1", "1005"));
		Station.Add(new StationList("덕계", "1", "1910"));
		Station.Add(new StationList("덕정", "1", "1911"));
		Station.Add(new StationList("도봉", "1", "1902"));
		Station.Add(new StationList("도봉산", "1", "1903"));
		Station.Add(new StationList("도원", "1", "1817"));
		Station.Add(new StationList("도화", "1", "1823"));
		Station.Add(new StationList("독산", "1", "1714"));
		Station.Add(new StationList("동대문", "1", "0155"));
		Station.Add(new StationList("동두천", "1", "1915"));
		Station.Add(new StationList("동두천중앙", "1", "1913"));
		Station.Add(new StationList("동묘앞", "1", "0159"));
		Station.Add(new StationList("동암", "1", "1808"));
		Station.Add(new StationList("동인천", "1", "1811"));
		Station.Add(new StationList("두정", "1", "1727"));
		// Station.Add( new StationList( "마전(무정차)", "1", "1917" ) );
		Station.Add(new StationList("망월사", "1", "1904"));
		Station.Add(new StationList("명학", "1", "1707"));
		Station.Add(new StationList("방학", "1", "1901"));
		Station.Add(new StationList("배방", "1", "1405"));
		Station.Add(new StationList("백운", "1", "1807"));
		Station.Add(new StationList("병점", "1", "1716"));
		Station.Add(new StationList("보산", "1", "1914"));
		Station.Add(new StationList("봉명", "1", "1401"));
		Station.Add(new StationList("부개", "1", "1815"));
		Station.Add(new StationList("부천", "1", "1804"));
		Station.Add(new StationList("부평", "1", "1806"));
		Station.Add(new StationList("서동탄", "1", "1749"));
		Station.Add(new StationList("서울역", "1", "0150"));
		Station.Add(new StationList("서정리", "1", "1722"));
		Station.Add(new StationList("석계", "1", "1018"));
		Station.Add(new StationList("석수", "1", "1704"));
		Station.Add(new StationList("성균관대", "1", "1711"));
		Station.Add(new StationList("성북", "1", "1019"));
		Station.Add(new StationList("성환", "1", "1725"));
		Station.Add(new StationList("세류", "1", "1715"));
		Station.Add(new StationList("세마", "1", "1717"));
		Station.Add(new StationList("소사", "1", "1814"));
		Station.Add(new StationList("소요산", "1", "1916"));
		Station.Add(new StationList("송내", "1", "1805"));
		Station.Add(new StationList("송탄", "1", "1721"));
		Station.Add(new StationList("수원", "1", "1713"));
		Station.Add(new StationList("시청", "1", "0151"));
		Station.Add(new StationList("신길", "1", "1032"));
		Station.Add(new StationList("신도림", "1", "1007"));
		Station.Add(new StationList("신설동", "1", "0156"));
		Station.Add(new StationList("신이문", "1", "1017"));
		Station.Add(new StationList("신창", "1", "1408"));
		Station.Add(new StationList("쌍용", "1", "1402"));
		Station.Add(new StationList("아산", "1", "1403"));
		Station.Add(new StationList("안양", "1", "1706"));
		Station.Add(new StationList("양주", "1", "1909"));
		Station.Add(new StationList("역곡", "1", "1803"));
		Station.Add(new StationList("영등포", "1", "1006"));
		Station.Add(new StationList("오류동", "1", "1802"));
		Station.Add(new StationList("오산", "1", "1719"));
		Station.Add(new StationList("오산대", "1", "1718"));
		Station.Add(new StationList("온수", "1", "1821"));
		Station.Add(new StationList("온양온천", "1", "1407"));
		Station.Add(new StationList("외대앞", "1", "1016"));
		Station.Add(new StationList("용산", "1", "1003"));
		Station.Add(new StationList("월계", "1", "1020"));
		Station.Add(new StationList("의왕", "1", "1710"));
		Station.Add(new StationList("의정부", "1", "1906"));
		Station.Add(new StationList("인천", "1", "1812"));
		Station.Add(new StationList("제기동", "1", "0157"));
		Station.Add(new StationList("제물포", "1", "1810"));
		Station.Add(new StationList("종각", "1", "0152"));
		Station.Add(new StationList("종로3가", "1", "0153"));
		Station.Add(new StationList("종로5가", "1", "0154"));
		Station.Add(new StationList("주안", "1", "1809"));
		Station.Add(new StationList("중동", "1", "1822"));
		Station.Add(new StationList("지제", "1", "1723"));
		Station.Add(new StationList("지행", "1", "1912"));
		Station.Add(new StationList("직산", "1", "1726"));
		Station.Add(new StationList("진위", "1", "1720"));
		Station.Add(new StationList("창동", "1", "1022"));
		Station.Add(new StationList("천안", "1", "1728"));
		Station.Add(new StationList("청량리", "1", "0158"));
		// Station.Add( new StationList( "탕정", "1", "1404" ) );
		Station.Add(new StationList("평택", "1", "1724"));
		// Station.Add( new StationList( "풍기", "1", "1406" ) );
		Station.Add(new StationList("화서", "1", "1712"));
		Station.Add(new StationList("회기", "1", "1015"));
		Station.Add(new StationList("회룡", "1", "1905"));

		// 2호선
		Station.Add(new StationList("강남", "2", "0222"));
		Station.Add(new StationList("강변", "2", "0214"));
		Station.Add(new StationList("건대입구", "2", "0212"));
		Station.Add(new StationList("교대", "2", "0223"));
		Station.Add(new StationList("구로디지털단지", "2", "0232"));
		Station.Add(new StationList("구의", "2", "0213"));
		Station.Add(new StationList("까치산", "2", "0260"));
		Station.Add(new StationList("낙성대", "2", "0227"));
		Station.Add(new StationList("당산", "2", "0237"));
		Station.Add(new StationList("대림", "2", "0233"));
		Station.Add(new StationList("도림천", "2", "0247"));
		Station.Add(new StationList("동대문역사문화공원", "2", "0205"));
		Station.Add(new StationList("뚝섬", "2", "0210"));
		Station.Add(new StationList("문래", "2", "0235"));
		Station.Add(new StationList("방배", "2", "0225"));
		Station.Add(new StationList("봉천", "2", "0229"));
		Station.Add(new StationList("사당", "2", "0226"));
		Station.Add(new StationList("삼성", "2", "0219"));
		Station.Add(new StationList("상왕십리", "2", "0207"));
		Station.Add(new StationList("서울대입구", "2", "0228"));
		Station.Add(new StationList("서초", "2", "0224"));
		Station.Add(new StationList("선릉", "2", "0220"));
		Station.Add(new StationList("성수", "2", "0211"));
		Station.Add(new StationList("시청", "2", "0201"));
		Station.Add(new StationList("신답", "2", "0245"));
		Station.Add(new StationList("신당", "2", "0206"));
		Station.Add(new StationList("신대방", "2", "0231"));
		Station.Add(new StationList("신도림", "2", "0234"));
		Station.Add(new StationList("신림", "2", "0230"));
		Station.Add(new StationList("신설동", "2", "0246"));
		Station.Add(new StationList("신정네거리", "2", "0249"));
		Station.Add(new StationList("신천", "2", "0217"));
		Station.Add(new StationList("신촌", "2", "0240"));
		Station.Add(new StationList("아현", "2", "0242"));
		Station.Add(new StationList("양천구청", "2", "0248"));
		Station.Add(new StationList("역삼", "2", "0221"));
		Station.Add(new StationList("영등포구청", "2", "0236"));
		Station.Add(new StationList("왕십리", "2", "0208"));
		Station.Add(new StationList("용답", "2", "0244"));
		Station.Add(new StationList("용두", "2", "0250"));
		Station.Add(new StationList("을지로3가", "2", "0203"));
		Station.Add(new StationList("을지로4가", "2", "0204"));
		Station.Add(new StationList("을지로입구", "2", "0202"));
		Station.Add(new StationList("이대", "2", "0241"));
		Station.Add(new StationList("잠실", "2", "0216"));
		Station.Add(new StationList("잠실나루", "2", "0215"));
		Station.Add(new StationList("종합운동장", "2", "0218"));
		Station.Add(new StationList("충정로", "2", "0243"));
		Station.Add(new StationList("한양대", "2", "0209"));
		Station.Add(new StationList("합정", "2", "0238"));
		Station.Add(new StationList("홍대입구", "2", "0239"));

		// 3호선
		Station.Add(new StationList("가락시장", "3", "0340"));
		Station.Add(new StationList("경복궁", "3", "0317"));
		Station.Add(new StationList("경찰병원", "3", "0341"));
		Station.Add(new StationList("고속터미널", "3", "0329"));
		Station.Add(new StationList("교대", "3", "0330"));
		Station.Add(new StationList("구파발", "3", "0310"));
		Station.Add(new StationList("금호", "3", "0324"));
		Station.Add(new StationList("남부터미널", "3", "0331"));
		Station.Add(new StationList("녹번", "3", "0313"));
		Station.Add(new StationList("대곡", "3", "1953"));
		Station.Add(new StationList("대청", "3", "0337"));
		Station.Add(new StationList("대치", "3", "0335"));
		Station.Add(new StationList("대화", "3", "1958"));
		Station.Add(new StationList("도곡", "3", "0334"));
		Station.Add(new StationList("독립문", "3", "0316"));
		Station.Add(new StationList("동대입구", "3", "0322"));
		Station.Add(new StationList("마두", "3", "1955"));
		Station.Add(new StationList("매봉", "3", "0333"));
		Station.Add(new StationList("무악재", "3", "0315"));
		Station.Add(new StationList("백석", "3", "1954"));
		Station.Add(new StationList("불광", "3", "0312"));
		Station.Add(new StationList("삼송", "3", "1950"));
		Station.Add(new StationList("수서", "3", "0339"));
		Station.Add(new StationList("신사", "3", "0327"));
		Station.Add(new StationList("안국", "3", "0318"));
		Station.Add(new StationList("압구정", "3", "0326"));
		Station.Add(new StationList("약수", "3", "0323"));
		Station.Add(new StationList("양재", "3", "0332"));
		Station.Add(new StationList("연신내", "3", "0311"));
		Station.Add(new StationList("오금", "3", "0342"));
		Station.Add(new StationList("옥수", "3", "0325"));
		Station.Add(new StationList("원당", "3", "1951"));
		Station.Add(new StationList("을지로3가", "3", "0320"));
		Station.Add(new StationList("일원", "3", "0338"));
		Station.Add(new StationList("잠원", "3", "0328"));
		Station.Add(new StationList("정발산", "3", "1956"));
		Station.Add(new StationList("종로3가", "3", "0319"));
		Station.Add(new StationList("주엽", "3", "1957"));
		Station.Add(new StationList("지축", "3", "0309"));
		Station.Add(new StationList("충무로", "3", "0321"));
		Station.Add(new StationList("학여울", "3", "0336"));
		Station.Add(new StationList("홍제", "3", "0314"));
		Station.Add(new StationList("화정", "3", "1952"));

		// 4호선
		Station.Add(new StationList("경마공원", "4", "1451"));
		Station.Add(new StationList("고잔", "4", "1757"));
		Station.Add(new StationList("공단", "4", "1758"));
		Station.Add(new StationList("과천", "4", "1453"));
		Station.Add(new StationList("금정", "4", "1458"));
		Station.Add(new StationList("길음", "4", "0417"));
		Station.Add(new StationList("남태령", "4", "0434"));
		Station.Add(new StationList("노원", "4", "0411"));
		Station.Add(new StationList("당고개", "4", "0409"));
		Station.Add(new StationList("대공원", "4", "1452"));
		Station.Add(new StationList("대야미", "4", "1752"));
		Station.Add(new StationList("동대문", "4", "0421"));
		Station.Add(new StationList("동대문역사문화공원", "4", "0422"));
		Station.Add(new StationList("동작", "4", "0431"));
		Station.Add(new StationList("명동", "4", "0424"));
		Station.Add(new StationList("미아", "4", "0415"));
		Station.Add(new StationList("미아삼거리", "4", "0416"));
		Station.Add(new StationList("반월", "4", "1753"));
		Station.Add(new StationList("범계", "4", "1457"));
		Station.Add(new StationList("사당", "4", "0433"));
		Station.Add(new StationList("산본", "4", "1751"));
		Station.Add(new StationList("삼각지", "4", "0428"));
		Station.Add(new StationList("상계", "4", "0410"));
		Station.Add(new StationList("상록수", "4", "1754"));
		Station.Add(new StationList("서울역", "4", "0426"));
		Station.Add(new StationList("선바위", "4", "1450"));
		Station.Add(new StationList("성신여대입구", "4", "0418"));
		Station.Add(new StationList("수리산", "4", "1763"));
		Station.Add(new StationList("수유", "4", "0414"));
		Station.Add(new StationList("숙대입구", "4", "0427"));
		Station.Add(new StationList("신길온천", "4", "1760"));
		Station.Add(new StationList("신용산", "4", "0429"));
		Station.Add(new StationList("쌍문", "4", "0413"));
		Station.Add(new StationList("안산", "4", "1759"));
		Station.Add(new StationList("오이도", "4", "1762"));
		Station.Add(new StationList("이촌", "4", "0430"));
		Station.Add(new StationList("인덕원", "4", "1455"));
		Station.Add(new StationList("정부과천청사", "4", "1454"));
		Station.Add(new StationList("정왕", "4", "1761"));
		Station.Add(new StationList("중앙", "4", "1756"));
		Station.Add(new StationList("창동", "4", "0412"));
		Station.Add(new StationList("총신대입구", "4", "0432"));
		Station.Add(new StationList("충무로", "4", "0423"));
		Station.Add(new StationList("평촌", "4", "1456"));
		Station.Add(new StationList("한대앞", "4", "1755"));
		Station.Add(new StationList("한성대입구", "4", "0419"));
		Station.Add(new StationList("혜화", "4", "0420"));
		Station.Add(new StationList("회현", "4", "0425"));

		// 5호선
		Station.Add(new StationList("강동", "5", "2549"));
		Station.Add(new StationList("개롱", "5", "2559"));
		Station.Add(new StationList("개화산", "5", "2512"));
		Station.Add(new StationList("거여", "5", "2560"));
		Station.Add(new StationList("고덕", "5", "2553"));
		Station.Add(new StationList("공덕", "5", "2530"));
		Station.Add(new StationList("광나루", "5", "2547"));
		Station.Add(new StationList("광화문", "5", "2534"));
		Station.Add(new StationList("군자", "5", "2545"));
		Station.Add(new StationList("굽은다리", "5", "2551"));
		Station.Add(new StationList("길동", "5", "2550"));
		Station.Add(new StationList("김포공항", "5", "2513"));
		Station.Add(new StationList("까치산", "5", "2519"));
		Station.Add(new StationList("답십리", "5", "2543"));
		Station.Add(new StationList("동대문역사문화공원", "5", "2537"));
		Station.Add(new StationList("둔촌동", "5", "2555"));
		Station.Add(new StationList("마곡", "5", "2515"));
		Station.Add(new StationList("마장", "5", "2542"));
		Station.Add(new StationList("마천", "5", "2561"));
		Station.Add(new StationList("마포", "5", "2529"));
		Station.Add(new StationList("명일", "5", "2552"));
		Station.Add(new StationList("목동", "5", "2521"));
		Station.Add(new StationList("발산", "5", "2516"));
		Station.Add(new StationList("방이", "5", "2557"));
		Station.Add(new StationList("방화", "5", "2511"));
		Station.Add(new StationList("상일동", "5", "2554"));
		Station.Add(new StationList("서대문", "5", "2533"));
		Station.Add(new StationList("송정", "5", "2514"));
		Station.Add(new StationList("신금호", "5", "2539"));
		Station.Add(new StationList("신길", "5", "2526"));
		Station.Add(new StationList("신정", "5", "2520"));
		Station.Add(new StationList("아차산", "5", "2546"));
		Station.Add(new StationList("애오개", "5", "2531"));
		Station.Add(new StationList("양평", "5", "2523"));
		Station.Add(new StationList("여의나루", "5", "2528"));
		Station.Add(new StationList("여의도", "5", "2527"));
		Station.Add(new StationList("영등포구청", "5", "2524"));
		Station.Add(new StationList("영등포시장", "5", "2525"));
		Station.Add(new StationList("오금", "5", "2558"));
		Station.Add(new StationList("오목교", "5", "2522"));
		Station.Add(new StationList("올림픽공원", "5", "2556"));
		Station.Add(new StationList("왕십리", "5", "2541"));
		Station.Add(new StationList("우장산", "5", "2517"));
		Station.Add(new StationList("을지로4가", "5", "2536"));
		Station.Add(new StationList("장한평", "5", "2544"));
		Station.Add(new StationList("종로3가", "5", "2535"));
		Station.Add(new StationList("천호", "5", "2548"));
		Station.Add(new StationList("청구", "5", "2538"));
		Station.Add(new StationList("충정로", "5", "2532"));
		Station.Add(new StationList("행당", "5", "2540"));
		Station.Add(new StationList("화곡", "5", "2518"));

		// 6호선
		Station.Add(new StationList("고려대", "6", "2641"));
		Station.Add(new StationList("공덕", "6", "2627"));
		Station.Add(new StationList("광흥창", "6", "2625"));
		Station.Add(new StationList("구산", "6", "2616"));
		Station.Add(new StationList("녹사평", "6", "2630"));
		Station.Add(new StationList("대흥", "6", "2626"));
		Station.Add(new StationList("독바위", "6", "2614"));
		Station.Add(new StationList("돌곶이", "6", "2644"));
		Station.Add(new StationList("동묘앞", "6", "2637"));
		Station.Add(new StationList("디지털미디어시티", "6", "2619"));
		Station.Add(new StationList("마포구청", "6", "2621"));
		Station.Add(new StationList("망원", "6", "2622"));
		Station.Add(new StationList("버티고개", "6", "2633"));
		Station.Add(new StationList("보문", "6", "2639"));
		Station.Add(new StationList("봉화산", "6", "2648"));
		Station.Add(new StationList("불광", "6", "2613"));
		Station.Add(new StationList("삼각지", "6", "2629"));
		Station.Add(new StationList("상수", "6", "2624"));
		Station.Add(new StationList("상월곡", "6", "2643"));
		Station.Add(new StationList("새절", "6", "2617"));
		Station.Add(new StationList("석계", "6", "2645"));
		Station.Add(new StationList("신당", "6", "2636"));
		Station.Add(new StationList("안암", "6", "2640"));
		Station.Add(new StationList("약수", "6", "2634"));
		Station.Add(new StationList("역촌", "6", "2612"));
		Station.Add(new StationList("연신내", "6", "2615"));
		Station.Add(new StationList("월곡", "6", "2642"));
		Station.Add(new StationList("월드컵경기장", "6", "2620"));
		Station.Add(new StationList("응암", "6", "2611"));
		Station.Add(new StationList("이태원", "6", "2631"));
		Station.Add(new StationList("증산", "6", "2618"));
		Station.Add(new StationList("창신", "6", "2638"));
		Station.Add(new StationList("청구", "6", "2635"));
		Station.Add(new StationList("태릉입구", "6", "2646"));
		Station.Add(new StationList("한강진", "6", "2632"));
		Station.Add(new StationList("합정", "6", "2623"));
		Station.Add(new StationList("화랑대", "6", "2647"));
		Station.Add(new StationList("효창공원앞", "6", "2628"));

		// 7호선
		Station.Add(new StationList("가산디지털단지", "7", "2748"));
		Station.Add(new StationList("강남구청", "7", "2732"));
		Station.Add(new StationList("건대입구", "7", "2729"));
		Station.Add(new StationList("고속터미널", "7", "2736"));
		Station.Add(new StationList("공릉", "7", "2718"));
		Station.Add(new StationList("광명사거리", "7", "2750"));
		Station.Add(new StationList("군자", "7", "2727"));
		Station.Add(new StationList("남구로", "7", "2747"));
		Station.Add(new StationList("남성", "7", "2739"));
		Station.Add(new StationList("내방", "7", "2737"));
		Station.Add(new StationList("노원", "7", "2715"));
		Station.Add(new StationList("논현", "7", "2734"));
		Station.Add(new StationList("대림", "7", "2746"));
		Station.Add(new StationList("도봉산", "7", "2712"));
		Station.Add(new StationList("뚝섬유원지", "7", "2730"));
		Station.Add(new StationList("마들", "7", "2714"));
		Station.Add(new StationList("먹골", "7", "2720"));
		Station.Add(new StationList("면목", "7", "2723"));
		Station.Add(new StationList("반포", "7", "2735"));
		Station.Add(new StationList("보라매", "7", "2744"));
		Station.Add(new StationList("사가정", "7", "2724"));
		Station.Add(new StationList("상도", "7", "2741"));
		Station.Add(new StationList("상봉", "7", "2722"));
		Station.Add(new StationList("수락산", "7", "2713"));
		Station.Add(new StationList("숭실대입구", "7", "2740"));
		Station.Add(new StationList("신대방삼거리", "7", "2743"));
		Station.Add(new StationList("신풍", "7", "2745"));
		Station.Add(new StationList("어린이대공원", "7", "2728"));
		Station.Add(new StationList("온수", "7", "2752"));
		Station.Add(new StationList("용마산", "7", "2725"));
		Station.Add(new StationList("이수", "7", "2738"));
		Station.Add(new StationList("장승배기", "7", "2742"));
		Station.Add(new StationList("장암", "7", "2711"));
		Station.Add(new StationList("중계", "7", "2716"));
		Station.Add(new StationList("중곡", "7", "2726"));
		Station.Add(new StationList("중화", "7", "2721"));
		Station.Add(new StationList("천왕", "7", "2751"));
		Station.Add(new StationList("철산", "7", "2749"));
		Station.Add(new StationList("청담", "7", "2731"));
		Station.Add(new StationList("태릉입구", "7", "2719"));
		Station.Add(new StationList("하계", "7", "2717"));
		Station.Add(new StationList("학동", "7", "2733"));

		// 8호선
		Station.Add(new StationList("가락시장", "8", "2818"));
		Station.Add(new StationList("강동구청", "8", "2813"));
		Station.Add(new StationList("남한산성입구", "8", "2823"));
		Station.Add(new StationList("단대오거리", "8", "2824"));
		Station.Add(new StationList("모란", "8", "2827"));
		Station.Add(new StationList("몽촌토성", "8", "2814"));
		Station.Add(new StationList("문정", "8", "2819"));
		Station.Add(new StationList("복정", "8", "2821"));
		Station.Add(new StationList("산성", "8", "2822"));
		Station.Add(new StationList("석촌", "8", "2816"));
		Station.Add(new StationList("송파", "8", "2817"));
		Station.Add(new StationList("수진", "8", "2826"));
		Station.Add(new StationList("신흥", "8", "2825"));
		Station.Add(new StationList("암사", "8", "2811"));
		Station.Add(new StationList("잠실", "8", "2815"));
		Station.Add(new StationList("장지", "8", "2820"));
		Station.Add(new StationList("천호", "8", "2812"));

		// 9호선
		Station.Add(new StationList("가양", "9", "4107"));
		Station.Add(new StationList("개화", "9", "4101"));
		Station.Add(new StationList("고속터미널", "9", "4123"));
		Station.Add(new StationList("공항시장", "9", "4103"));
		Station.Add(new StationList("구반포", "9", "4121"));
		Station.Add(new StationList("국회의사당", "9", "4114"));
		Station.Add(new StationList("김포공항", "9", "4102"));
		Station.Add(new StationList("노들", "9", "4118"));
		Station.Add(new StationList("노량진", "9", "4117"));
		Station.Add(new StationList("당산", "9", "4113"));
		Station.Add(new StationList("동작", "9", "4120"));
		Station.Add(new StationList("등촌", "9", "4109"));
		Station.Add(new StationList("마곡나루", "9", "4105"));
		Station.Add(new StationList("사평", "9", "4124"));
		Station.Add(new StationList("샛강", "9", "4116"));
		Station.Add(new StationList("선유도", "9", "4112"));
		Station.Add(new StationList("신논현", "9", "4125"));
		Station.Add(new StationList("신목동", "9", "4111"));
		Station.Add(new StationList("신반포", "9", "4122"));
		Station.Add(new StationList("신방화", "9", "4104"));
		Station.Add(new StationList("양천향교", "9", "4106"));
		Station.Add(new StationList("여의도", "9", "4115"));
		Station.Add(new StationList("염창", "9", "4110"));
		Station.Add(new StationList("증미", "9", "4108"));
		Station.Add(new StationList("흑석", "9", "4119"));

		// 분당선
		Station.Add(new StationList("개포동", "B", "1027"));
		Station.Add(new StationList("경원대", "B", "1851"));
		Station.Add(new StationList("구룡", "B", "1026"));
		Station.Add(new StationList("대모산입구", "B", "1028"));
		Station.Add(new StationList("도곡", "B", "1025"));
		Station.Add(new StationList("모란", "B", "1853"));
		Station.Add(new StationList("미금", "B", "1858"));
		Station.Add(new StationList("보정", "B", "1861"));
		Station.Add(new StationList("복정", "B", "1031"));
		Station.Add(new StationList("서현", "B", "1855"));
		Station.Add(new StationList("선릉", "B", "1023"));
		Station.Add(new StationList("수내", "B", "1856"));
		Station.Add(new StationList("수서", "B", "1030"));
		Station.Add(new StationList("야탑", "B", "1854"));
		Station.Add(new StationList("오리", "B", "1859"));
		Station.Add(new StationList("이매", "B", "1860"));
		Station.Add(new StationList("정자", "B", "1857"));
		Station.Add(new StationList("죽전", "B", "1862"));
		Station.Add(new StationList("태평", "B", "1852"));
		Station.Add(new StationList("한티", "B", "1024"));

		// 인천1호선
		Station.Add(new StationList("간석오거리", "I", "3123"));
		Station.Add(new StationList("갈산", "I", "3117"));
		Station.Add(new StationList("경인교대입구", "I", "3115"));
		Station.Add(new StationList("계산", "I", "3114"));
		Station.Add(new StationList("계양", "I", "3110"));
		Station.Add(new StationList("국제업무지구", "I", "3138"));
		Station.Add(new StationList("귤현", "I", "3111"));
		Station.Add(new StationList("동막", "I", "3132"));
		Station.Add(new StationList("동수", "I", "3121"));
		Station.Add(new StationList("동춘", "I", "3131"));
		Station.Add(new StationList("문학경기장", "I", "3127"));
		Station.Add(new StationList("박촌", "I", "3112"));
		Station.Add(new StationList("부평", "I", "3120"));
		Station.Add(new StationList("부평구청", "I", "3118"));
		Station.Add(new StationList("부평삼거리", "I", "3122"));
		Station.Add(new StationList("부평시장", "I", "3119"));
		Station.Add(new StationList("선학", "I", "3128"));
		Station.Add(new StationList("센트럴파크", "I", "3137"));
		Station.Add(new StationList("신연수", "I", "3129"));
		Station.Add(new StationList("예술회관", "I", "3125"));
		Station.Add(new StationList("원인재", "I", "3130"));
		Station.Add(new StationList("인천대입구", "I", "3136"));
		Station.Add(new StationList("인천시청", "I", "3124"));
		Station.Add(new StationList("인천터미널", "I", "3126"));
		Station.Add(new StationList("임학", "I", "3113"));
		Station.Add(new StationList("작전", "I", "3116"));
		Station.Add(new StationList("지식정보단지", "I", "3135"));
		Station.Add(new StationList("캠퍼스타운", "I", "3133"));
		Station.Add(new StationList("테크노파크", "I", "3134"));

		// 중앙선
		Station.Add(new StationList("구리", "J", "1205"));
		Station.Add(new StationList("국수", "J", "1214"));
		Station.Add(new StationList("덕소", "J", "1208"));
		Station.Add(new StationList("도농", "J", "1206"));
		Station.Add(new StationList("도심", "J", "1209"));
		Station.Add(new StationList("망우", "J", "1203"));
		Station.Add(new StationList("상봉", "J", "1202"));
		Station.Add(new StationList("서빙고", "J", "1009"));
		Station.Add(new StationList("신원", "J", "1213"));
		Station.Add(new StationList("아신", "J", "1215"));
		Station.Add(new StationList("양수", "J", "1212"));
		Station.Add(new StationList("양원", "J", "1204"));
		Station.Add(new StationList("양정", "J", "1207"));
		Station.Add(new StationList("양평", "J", "1217"));
		Station.Add(new StationList("오빈", "J", "1216"));
		Station.Add(new StationList("옥수", "J", "1011"));
		Station.Add(new StationList("왕십리", "J", "1013"));
		Station.Add(new StationList("용문", "J", "1219"));
		Station.Add(new StationList("용산", "J", "1290"));
		Station.Add(new StationList("운길산", "J", "1211"));
		Station.Add(new StationList("원덕", "J", "1218"));
		Station.Add(new StationList("응봉", "J", "1012"));
		Station.Add(new StationList("이촌", "J", "1008"));
		Station.Add(new StationList("중랑", "J", "1201"));
		Station.Add(new StationList("청량리", "J", "1014"));
		Station.Add(new StationList("팔당", "J", "1210"));
		Station.Add(new StationList("한남", "J", "1010"));
		Station.Add(new StationList("회기", "J", "1200"));

		// 경의선
		Station.Add(new StationList("가좌", "K", "1265"));
		Station.Add(new StationList("곡산", "K", "1272"));
		Station.Add(new StationList("금릉", "K", "1279"));
		Station.Add(new StationList("금촌", "K", "1280"));
		Station.Add(new StationList("능곡", "K", "1271"));
		Station.Add(new StationList("대곡", "K", "1249"));
		Station.Add(new StationList("디지털미디어시티", "K", "1266"));
		Station.Add(new StationList("문산", "K", "1284"));
		Station.Add(new StationList("백마", "K", "1273"));
		Station.Add(new StationList("서울역", "K", "1251"));
		Station.Add(new StationList("수색", "K", "1267"));
		Station.Add(new StationList("신촌", "K", "1252"));
		Station.Add(new StationList("운정", "K", "1278"));
		Station.Add(new StationList("월롱", "K", "1282"));
		Station.Add(new StationList("일산", "K", "1275"));
		Station.Add(new StationList("탄현", "K", "1276"));
		Station.Add(new StationList("파주", "K", "1283"));
		Station.Add(new StationList("풍산", "K", "1274"));
		Station.Add(new StationList("행신", "K", "1270"));
		Station.Add(new StationList("화전", "K", "1268"));

		// 공항철도 2단계 완전개통

		// 2011.12.31 개통예정
		// Station.Add( new StationList( "공덕", "A", "") );
		Station.Add(new StationList("검암", "A", "4209"));
		Station.Add(new StationList("계양", "A", "4208"));
		Station.Add(new StationList("공항화물청사", "A", "4212"));
		Station.Add(new StationList("김포공항", "A", "4207"));
		Station.Add(new StationList("디지털미디어시티", "A", "1294"));
		Station.Add(new StationList("서울역", "A", "1291"));
		Station.Add(new StationList("운서", "A", "4211"));
		Station.Add(new StationList("인천국제공항", "A", "4213"));
		Station.Add(new StationList("홍대입구", "A", "1293"));

		// 경춘선
		Station.Add(new StationList("가평", "G", "1323"));
		Station.Add(new StationList("갈매", "G", "1312"));
		Station.Add(new StationList("강촌", "G", "1326"));
		Station.Add(new StationList("굴봉산", "G", "1324"));
		Station.Add(new StationList("금곡", "G", "1316"));
		Station.Add(new StationList("김유정", "G", "1327"));
		Station.Add(new StationList("남춘천", "G", "1328"));
		Station.Add(new StationList("대성리", "G", "1320"));
		Station.Add(new StationList("마석", "G", "1319"));
		Station.Add(new StationList("망우", "G", "1310"));
		Station.Add(new StationList("백양리", "G", "1325"));
		Station.Add(new StationList("사릉", "G", "1315"));
		Station.Add(new StationList("상봉", "G", "1309"));
		Station.Add(new StationList("상천", "G", "1322"));
		Station.Add(new StationList("청평", "G", "1321"));
		Station.Add(new StationList("춘천", "G", "1329"));
		Station.Add(new StationList("퇴계원", "G", "1314"));
		Station.Add(new StationList("평내호평", "G", "1317"));
         
        }
    }
    struct StationList
    {
        private string _name;
        private string _line;
        private string _code;
        
        
        public StationList(string name, string line, string code)
        {
            _name=name;
            _line=line;
            _code=code;
        }
    }
}
