<%-- 
    Document   : detailSV
    Created on : Apr 8, 2022, 2:26:06 PM
    Author     : Admin
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <!-- basic -->
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <!-- mobile metas -->
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="viewport" content="initial-scale=1, maximum-scale=1">
        <!-- site metas -->
        <title>WS</title>
        <meta name="keywords" content="">
        <meta name="description" content="">
        <meta name="author" content="">
        <!-- bootstrap css -->
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <!-- style css -->
        <link rel="stylesheet" href="css/style.css">
        <!-- Responsive-->
        <link rel="stylesheet" href="css/responsive.css">
        <!-- fevicon -->
        <link rel="icon" href="images/fevicon.png" type="image/gif" />
        <!-- Scrollbar Custom CSS -->
        <link rel="stylesheet" href="css/jquery.mCustomScrollbar.min.css">
        <!-- Tweaks for older IEs-->
        <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css">
        <!-- owl stylesheets -->
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link rel="stylesheet" href="css/owl.carousel.min.css">
        <link rel="stylesheet" href="css/owl.theme.default.min.css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css" media="screen">
        <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
          <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script><![endif]-->
    </head>
    <body>
        <jsp:include page="layout/header.jsp"/>
        <div class="brand_color">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="titlepage">
                            <h2>Chi tiết người giúp việc</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Product -->
        <div class="product container">
            <div class ="product__containt">
                <div class="product-content row">
                    <div class="product-content-left row">
                        <div class="product-content-left-big-img">
                            <img src="${s.getImglink()}"/>

                        </div>

                    </div>
                    <div class="product-content-right">
                        <div class="product-content-right-product-name">
                            <h1>${s.getName()}</h1>
                            <p>ID: ${s.getId()}</p>
                        </div>
                        <div class="product-content-right-product-price">
                            <h2>Giá: 100.000đ/1h</h2>
                        </div>
                        <div class="product-content-right-product-gioitinh">
                            <p><span style="font-weight: bold;">Giới tính</span>: Nữ</p>
                        </div>
                        <div class="product-content-right-product-namsinh">
                            <p><span style="font-weight: bold;">Năm sinh</span>: 1982</p>
                        </div>
                        <div class="product-content-right-product-sdt">
                            <p><span style="font-weight: bold;">Số điện thoại</span>: ${s.getPhone()}</p>
                        </div>
                        <div class="product-content-right-product-diachi">
                            <p><span style="font-weight: bold;">Quê quán</span>: ${s.getAddress()}</p>
                        </div>
                        <form method="post" action="seeDetail?sid=${s.getId()}">
                            <div class="quantity">
                                <p style="font-weight: bold;">Giờ thuê:</p>
                                <input type="text" name="totaltime">
                            </div>
                            <div class="product-content-right-product-button">
                                <input style="background-color: red; color: white; padding: 5px 10px;
                                       border-radius: 5px;" type="submit" value="Thuê">               
                            </div>
                        </form>
                        <div class="product-content-right-bottom">
                            <div class="product-content-right-bottom-top">
                                &#8744;
                            </div>
                        </div>
                        <div class="product-content-right-bottom-content-big">
                            <div class="product-content-right-bottom-content-title row">
                                <div class="product-content-right-bottom-content-title-item gioithieu">
                                    <p>Giới thiệu</p>

                                </div>
                                <div class="product-content-right-bottom-content-title-item kinhnghiem">
                                    <p>Kinh nghiệm</p>
                                </div>
                                <div class="product-content-right-bottom-content-title-item kinang">
                                    <p>Kĩ năng</p>
                                </div>
                            </div>
                            <div class="product-content-right-bottom-content">
                                <div class="product-content-right-bottom-content-gioithieu">
                                    Chị uy tín là hàng đầu, nhiệt tình là số 1.<br>
                                    Chị nhận làm giúp việc được 4 năm, công việc chủ yếu của chị là làm giúp việc nhà, dọn dẹp, nấu ăn và giặt giũ.<br>
                                    Chị còn trẻ nên sức khỏe tốt, sử dụng thành thạo các thiết bị trong gia đình.
                                </div>
                                <div class="product-content-right-bottom-content-kinhnghiem">
                                    Có 4 năm kinh nghiệm giúp việc gia đình
                                </div>
                                <div class="product-content-right-bottom-content-kinang">                           
                                    Công việc chị từng làm:<br><br>

                                    * Vệ sinh nhà cửa: phòng khách, phòng ngủ, bếp ăn, nhà vệ sinh…<br>
                                    * Vệ sinh quét bụi và mạng nhện mặt trần, lau chùi xung quanh các máng đèn & các vật dụng trên trần.<br>
                                    * Làm sạch tường, chân tường, những khoảng bị dính bẩn.<br>
                                    * Cửa gỗ, cửa kính & cửa sổ kính bên trong và bên ngoài…<br>
                                    * Cầu thang bộ: làm sạch & lau các bậc thang, tay vịn cầu thang.<br>
                                    * Nội thất: giặt salon, ghế, nệm…<br>
                                    * Sử dụng các thiết bị gia đình: máy giặt, máy hút bụi, máy ủi đồ, máy rửa bát, bếp ga, nồi cơm điện…<br>
                                    * Giặt quần áo, phơi đồ, ủi đồ, sắp xếp quần áo…<br>
                                    * Đi chợ, nấu cơm…<br>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <jsp:include page="layout/footer.jsp"/>
        <!-- Javascript files-->
        <script src="js/jquery.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.bundle.min.js"></script>
        <script src="js/jquery-3.0.0.min.js"></script>
        <script src="js/plugin.js"></script>
        <!-- sidebar -->
        <script src="js/jquery.mCustomScrollbar.concat.min.js"></script>
        <script src="js/custom.js"></script>
        <!-- javascript -->
        <script src="js/owl.carousel.js"></script>
        <script src="https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js"></script>
        <script>
            $(document).ready(function () {
                $(".fancybox").fancybox({
                    openEffect: "none",
                    closeEffect: "none"
                });

                $(".zoom").hover(function () {

                    $(this).addClass('transition');
                }, function () {

                    $(this).removeClass('transition');
                });
            });
        </script>
    </body>
</html>
