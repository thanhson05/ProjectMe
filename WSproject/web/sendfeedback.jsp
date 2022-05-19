
<%-- 
    Document   : sendfeedback
    Created on : Apr 8, 2022, 1:52:25 PM
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
                                <h2> Hãy cho chúng tôi biết bạn nghĩ gì ${sessionScope.user}:</h2>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        <!-- contact -->
        <div class="contact">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <form class="main_form" method="post" action="sendFb">
                            <div class="row" >
                                <div class="col-md-12">
                                    <textarea class="textarea" name="mess" placeholder="Message"></textarea>
                                </div>
                                <div class="stars" style="margin-left: 35%">
                                    <input class="star3 star3-5" value="5" id="star3-5" type="radio" name="star"/>
                                    <label class="star3 star3-5" for="star3-5"></label>
                                    <input class="star3 star3-4" value="4" id="star3-4" type="radio" name="star"/>
                                    <label class="star3 star3-4" for="star3-4"></label>
                                    <input class="star3 star3-3" value="3" id="star3-3" type="radio" name="star"/>
                                    <label class="star3 star3-3" for="star3-3"></label>
                                    <input class="star3 star3-2" value="2" id="star3-2" type="radio" name="star"/>
                                    <label class="star3 star3-2" for="star3-2"></label>
                                    <input class="star3 star3-1" value="1" id="star3-1" type="radio" name="star"/>
                                    <label class="star3 star3-1" for="star3-1"></label>
                                </div>
                                <div class=" col-md-12">
                                    <input type="submit" value="Gửi" style="color: white; background-color: black; padding: 7px 35px; font-size: 25px;margin-left: 45%">
                                    <!--<a href=" "><button type="button" class="send">Gửi</button></a>-->
                                </div>
                            </div>
                        </form>
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
