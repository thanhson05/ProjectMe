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
                            <h2> Tất cả nhân viên</h2>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class="container">
            <div class="row">
                <button class="btn btn-primary btn-sm edit" style="margin: 10px" type="button" title="Sửa" id="show-emp"
                        data-toggle="modal" data-target="#ModalUPadd">Thêm nhân viên</button>
                <div class="modal fade" id="ModalUPadd" tabindex="-1" role="dialog" aria-hidden="true" data-backdrop="static"
                     data-keyboard="false">
                    <div class="modal-dialog modal-dialog-centered" role="document">
                        <div class="modal-content">
                            <div class="modal-body">
                                <form action="staffmanager?action=add" method="post">
                                    <div class="row">
                                        <div class="form-group  col-md-12">
                                            <span class="thong-tin-thanh-toan">
                                                <h5>Add Staff</h5>
                                            </span>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="form-group col-md-6">
                                            <label class="control-label"> Name</label>
                                            <input class="form-control" type="text" name="name" required >
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label class="control-label">Phone</label>
                                            <input class="form-control" type="text" name="phone" required v>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label class="control-label">Address</label>
                                            <input class="form-control" type="text" name="address" required >
                                        </div>
                                        <div class="form-group col-md-6">
                                            <label class="control-label">Image</label>
                                            <input class="form-control" type="text" name="img" >
                                        </div>
                                    </div>
                                    <BR>
                                    <button class="btn btn-save" type="submit">Lưu</button>
                                    <a class="btn btn-cancel" data-dismiss="modal" href="#">Hủy</a>
                                    <BR>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>


                <table class="table">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Staff Name</th>
                            <th>Phone</th>
                            <th>Address</th>
                            <th>Image</th>
                            <th>Delete</th>
                            <th>Edit</th>
                        </tr>
                    </thead>
                    <tbody>
                        <c:forEach items="${stafflist}" var="staff">
                            <tr>
                                <td>${staff.getId()}</td>
                                <td>${staff.getName()}</td>
                                <td>${staff.getPhone()}</td>
                                <td>${staff.getAddress()}</td>
                                <td> <img src="${staff.getImglink()}" alt="img" style="width: 100px" /></td>
                                <td><a href="staffmanager?action=delete&sid=${staff.getId()}" style="color: red;
                                       text-decoration: none;">Xóa</a> </td>

                                <td>  <button class="btn btn-primary btn-sm edit" type="button" title="Sửa" id="show-emp"
                                              data-toggle="modal" data-target="#ModalUP${staff.getId()}">Sửa
                                    </button>
                                </td>
                            </tr>

                        <div class="modal fade" id="ModalUP${staff.getId()}" tabindex="-1" role="dialog" aria-hidden="true" data-backdrop="static"
                             data-keyboard="false">
                            <div class="modal-dialog modal-dialog-centered" role="document">
                                <div class="modal-content">
                                    <div class="modal-body">
                                        <form action="staffmanager?action=edit" method="post">
                                            <div class="row">
                                                <div class="form-group  col-md-12">
                                                    <span class="thong-tin-thanh-toan">
                                                        <h5>Chỉnh sửa thông tin nhân viên</h5>
                                                    </span>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="form-group col-md-6">
                                                    <label class="control-label"> ID</label>
                                                    <input class="form-control" type="text" readonly name="id" value="${staff.getId()}">
                                                </div>
                                                <div class="form-group col-md-6">
                                                    <label class="control-label"> Name</label>
                                                    <input class="form-control" type="text" name="name" required value="${staff.getName()}">
                                                </div>
                                                <div class="form-group col-md-6">
                                                    <label class="control-label">Phone</label>
                                                    <input class="form-control" type="text" name="phone" required value="${staff.getPhone()}">
                                                </div>
                                                <div class="form-group col-md-6">
                                                    <label class="control-label">Address</label>
                                                    <input class="form-control" type="text" name="address" required value="${staff.getAddress()}">
                                                </div>
                                                <div class="form-group col-md-6">
                                                    <label class="control-label">Image</label>
                                                    <input class="form-control" type="text" name="img" value="${staff.getImglink().trim()}">
                                                </div>
                                            </div>
                                            <BR>
                                            <button class="btn btn-save" type="submit">Lưu</button>
                                            <a class="btn btn-cancel" data-dismiss="modal" href="#">Xóa</a>
                                            <BR>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </c:forEach>

                    </tbody>
                </table>

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
