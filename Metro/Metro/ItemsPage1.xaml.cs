using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 항목 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234233에 나와 있습니다.

namespace Metro
{
    /// <summary>
    /// 항목 미리 보기 컬렉션을 표시하는 페이지입니다. 분할 응용 프로그램에서 이 페이지는
    /// 사용 가능한 그룹 중 하나를 표시 및 선택하는 데 사용됩니다.
    /// </summary>
    public sealed partial class ItemsPage1 : Metro.Common.LayoutAwarePage
    {
        public ItemsPage1()
        {
            this.InitializeComponent();
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
            // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
        }
    }
}
