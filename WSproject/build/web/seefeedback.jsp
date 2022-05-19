<%-- 
    Document   : seefeedback
    Created on : Apr 8, 2022, 2:25:50 PM
    Author     : Admin
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib uri = "http://java.sun.com/jsp/jstl/functions" prefix = "fn" %>
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
                            <h2> Tất cả phản hồi</h2>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class="container">
            <div class="row">
                <c:forEach items="${fb}" var="fb">
                    <div class="col-md-12" style="margin: 15px; border-bottom: 1px gray solid;">
                        <p3 id="ten">${fb.getUser().getName()}</p3>
                        <div>
                            <img id="img" src="https://genvita.vn/resources/avatar/a7dc31fd-b854-4156-8e62-a43dae88c954?width=119&height=119&mode=crop" style="width: 60px; height: auto;" alt="">
                        </div>
                        <div class="stars">
                            <c:if test="${fb.getRate()== 1}">
                                <i><img src="images/star.png"/></i>
                                </c:if>
                                <c:if test="${fb.getRate()== 2}">
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                </c:if>
                                <c:if test="${fb.getRate()== 3}">
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                </c:if>
                                <c:if test="${fb.getRate()== 4}">
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                </c:if>
                                <c:if test="${fb.getRate()== 5}">
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                <i><img src="images/star.png"/></i>
                                </c:if>
                            <!--                        <form action="">
                                                        <i><img src="images/star.png"/></i>
                                                        <i><img src="images/star.png"/></i>
                                                        <i><img src="images/star.png"/></i>
                                                        <i><img src="images/star.png"/></i>
                                                    </form>-->
                        </div> 

                        <div id="text">
                            <p>${fb.getMess()}</p>
                        </div>

                        <div class="remove">

                            <form action="">
                                <a href="seeFeedback?action=remove&fid=${fb.getId()}">  
                                    <label class="remove remove-6" for="remove remove-6"></label>
                                </a>
                            </form>
                        </div>
                    </div>
                </c:forEach>

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
