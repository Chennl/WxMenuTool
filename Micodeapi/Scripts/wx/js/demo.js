//$(function () {
//    var $tooltips = $('.js_tooltips');

//    $('#showTooltips').on('click', function () {
//        if ($tooltips.css('display') != 'none') return;
//        $('.page.cell').removeClass('slideIn');
//        $tooltips.css('display', 'block');
//        setTimeout(function () { $tooltips.css('display', 'none') }, 2000);
//    });
//});

//// 2.1 监听“分享给朋友”，按钮点击、自定义分享内容及分享结果接口
//document.querySelector('#onMenuShareAppMessage').onclick = function () {
//    wx.onMenuShareAppMessage({
//        title: '互联网之子',
//        desc: '在长大的过程中，我才慢慢发现，我身边的所有事，别人跟我说的所有事，那些所谓本来如此，注定如此的事，它们其实没有非得如此，事情是可以改变的。更重要的是，有些事既然错了，那就该做出改变。',
//        link: 'http://www.baidu.com',
//        imgUrl: 'http://img14.360buyimg.com/n5/jfs/t1279/210/287600770/128026/75262bb3/5562e4deN53c98f09.jpg',
        
//        //trigger: function (res) {
//            // 不要尝试在trigger中使用ajax异步请求修改本次分享的内容，因为客户端分享操作是一个同步操作，这时候使用ajax的回包会还没有返回
//            //alert('用户点击发送给朋友');
//        //},
//        success: function (res) {
//            alert('已分享');
//        },
//        cancel: function (res) {
//            alert('已取消');
//        },
//        fail: function (res) {
//            alert(JSON.stringify(res));
//        }
//    });
//    //alert('已注册获取“发送给朋友”状态事件');
//};