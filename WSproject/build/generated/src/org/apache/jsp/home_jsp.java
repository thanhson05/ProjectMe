package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class home_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.apache.jasper.runtime.TagHandlerPool _jspx_tagPool_c_forEach_var_items;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspInit() {
    _jspx_tagPool_c_forEach_var_items = org.apache.jasper.runtime.TagHandlerPool.getTagHandlerPool(getServletConfig());
  }

  public void _jspDestroy() {
    _jspx_tagPool_c_forEach_var_items.release();
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <!-- basic -->\n");
      out.write("        <meta charset=\"utf-8\">\n");
      out.write("        <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n");
      out.write("        <!-- mobile metas -->\n");
      out.write("        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n");
      out.write("        <meta name=\"viewport\" content=\"initial-scale=1, maximum-scale=1\">\n");
      out.write("        <!-- site metas -->\n");
      out.write("        <title>WS</title>\n");
      out.write("        <meta name=\"keywords\" content=\"\">\n");
      out.write("        <meta name=\"description\" content=\"\">\n");
      out.write("        <meta name=\"author\" content=\"\">\n");
      out.write("        <!-- bootstrap css -->\n");
      out.write("        <link rel=\"stylesheet\" href=\"css/bootstrap.min.css\">\n");
      out.write("        <!-- style css -->\n");
      out.write("        <link rel=\"stylesheet\" href=\"css/style.css\">\n");
      out.write("        <!-- Responsive-->\n");
      out.write("        <link rel=\"stylesheet\" href=\"css/responsive.css\">\n");
      out.write("        <!-- fevicon -->\n");
      out.write("        <link rel=\"icon\" href=\"images/fevicon.png\" type=\"image/gif\" />\n");
      out.write("        <!-- Scrollbar Custom CSS -->\n");
      out.write("        <link rel=\"stylesheet\" href=\"css/jquery.mCustomScrollbar.min.css\">\n");
      out.write("        <!-- Tweaks for older IEs-->\n");
      out.write("        <link rel=\"stylesheet\" href=\"https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css\">\n");
      out.write("        <!-- owl stylesheets -->\n");
      out.write("        <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\n");
      out.write("        <link rel=\"stylesheet\" href=\"css/owl.carousel.min.css\">\n");
      out.write("        <link rel=\"stylesheet\" href=\"css/owl.theme.default.min.css\">\n");
      out.write("        <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css\" media=\"screen\">\n");
      out.write("        <!--[if lt IE 9]>\n");
      out.write("          <script src=\"https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js\"></script>\n");
      out.write("          <script src=\"https://oss.maxcdn.com/respond/1.4.2/respond.min.js\"></script><![endif]-->\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("        ");
      org.apache.jasper.runtime.JspRuntimeLibrary.include(request, response, "layout/header.jsp", out, false);
      out.write("\n");
      out.write("        <section class=\"slider_section\">\n");
      out.write("            <div id=\"myCarousel\" class=\"carousel slide banner-main\" data-ride=\"carousel\">\n");
      out.write("                <div class=\"carousel-inner\">\n");
      out.write("                    <img  style=\"width:100%;\" class=\"first-slide\" src=\"./images/bn1.png\" alt=\"First slide\">\n");
      out.write("                </div>\n");
      out.write("        </section>\n");
      out.write("\n");
      out.write("        <!-- about -->\n");
      out.write("        <div class=\"about\">\n");
      out.write("            <div class=\"container\">\n");
      out.write("                <div class=\"row\">\n");
      out.write("                    <div class=\"col-xl-5 col-lg-5 col-md-5 co-sm-l2\">\n");
      out.write("                        <div class=\"about_img\">\n");
      out.write("                            <figure><img src=\"./images/abu.jpg\" alt=\"img\" /></figure>\n");
      out.write("                        </div>\n");
      out.write("                    </div>\n");
      out.write("                    <div class=\"col-xl-7 col-lg-7 col-md-7 co-sm-l2\">\n");
      out.write("                        <div class=\"about_box\">\n");
      out.write("                            <h3>Giới thiệu</h3>\n");
      out.write("                            <span>Dịch vụ cho thuê giúp việc</span>\n");
      out.write("                            <p> WS sẽ cung cấp cho các cư dân của căn hộ những dịch vụ về giúp việc tốt nhất <br> Bằng trách nhiệm và những thành tự mà WS đạt được chúng tôi cam kết sẽ làm việc với năng suất cao nhất hướng đến sự hài lòng tuyệt đối của quý khách hàng. </p>\n");
      out.write("                        </div>\n");
      out.write("\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("        <!-- end about -->\n");
      out.write("        <!-- brand -->\n");
      out.write("        <div class=\"brand\">\n");
      out.write("            <div class=\"container\">\n");
      out.write("                <div class=\"row\">\n");
      out.write("                    <div class=\"col-md-12\">\n");
      out.write("                        <div class=\"titlepage\">\n");
      out.write("                            <h2>Thuê giúp việc</h2>\n");
      out.write("                        </div>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("            <div class=\"brand-bg\">\n");
      out.write("                <div class=\"container\">\n");
      out.write("                    <div class=\"row\">\n");
      out.write("                        ");
      if (_jspx_meth_c_forEach_0(_jspx_page_context))
        return;
      out.write("\n");
      out.write("                    </div>\n");
      out.write("                    <div class=\"col-md-12\" style=\"display: flex; justify-content:center;\">\n");
      out.write("                        <a style=\"color: White; background-color:red;text-decoration:none; padding: 10px 25px;margin: 20px; font-size: 20px;\" class=\"read-more\" href=\"hireService\">Xem thêm</a>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("\n");
      out.write("\n");
      out.write("        <!-- end brand -->\n");
      out.write("        <!-- clients -->\n");
      out.write("        <div class=\"clients\">\n");
      out.write("            <div class=\"container\">\n");
      out.write("                <div class=\"row\">\n");
      out.write("                    <div class=\"col-md-12\">\n");
      out.write("                        <div class=\"titlepage\">\n");
      out.write("                            <h2>Lời nhắn</h2>\n");
      out.write("                        </div>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("        <div class=\"clients_red\">\n");
      out.write("            <div class=\"container\">\n");
      out.write("                <div id=\"testimonial_slider\" class=\"carousel slide\" data-ride=\"carousel\">\n");
      out.write("                    <!-- Indicators -->\n");
      out.write("                    <ul class=\"carousel-indicators\">\n");
      out.write("                        <li data-target=\"#testimonial_slider\" data-slide-to=\"0\" class=\"\"></li>\n");
      out.write("                        <li data-target=\"#testimonial_slider\" data-slide-to=\"1\" class=\"active\"></li>\n");
      out.write("                        <li data-target=\"#testimonial_slider\" data-slide-to=\"2\" class=\"\"></li>\n");
      out.write("                    </ul>\n");
      out.write("                    <!-- The slideshow -->\n");
      out.write("                    <div class=\"carousel-inner\">\n");
      out.write("                        <div class=\"carousel-item\">\n");
      out.write("                            <div class=\"testomonial_section\">\n");
      out.write("                                <div class=\"full center\">\n");
      out.write("                                </div>\n");
      out.write("                                <div class=\"full testimonial_cont text_align_center cross_layout\">\n");
      out.write("                                    <div class=\"cross_inner\">\n");
      out.write("                                        <h3>Due markes<br><strong class=\"ornage_color\">Rental</strong></h3>\n");
      out.write("                                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit ess</i>\n");
      out.write("                                        </p>\n");
      out.write("                                        <div class=\"full text_align_center margin_top_30\">\n");
      out.write("                                            <img src=\"icon/testimonial_qoute.png\">\n");
      out.write("                                        </div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("\n");
      out.write("                        <div class=\"carousel-item active\">\n");
      out.write("\n");
      out.write("                            <div class=\"testomonial_section\">\n");
      out.write("                                <div class=\"full center\">\n");
      out.write("                                </div>\n");
      out.write("                                <div class=\"full testimonial_cont text_align_center cross_layout\">\n");
      out.write("                                    <div class=\"cross_inner\">\n");
      out.write("                                        <h3>Due markes<br><strong class=\"ornage_color\">Rental</strong></h3>\n");
      out.write("                                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit ess</i>\n");
      out.write("                                        </p>\n");
      out.write("                                        <div class=\"full text_align_center margin_top_30\">\n");
      out.write("                                            <img src=\"icon/testimonial_qoute.png\">\n");
      out.write("                                        </div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("\n");
      out.write("                        </div>\n");
      out.write("\n");
      out.write("                        <div class=\"carousel-item\">\n");
      out.write("\n");
      out.write("                            <div class=\"testomonial_section\">\n");
      out.write("                                <div class=\"full center\">\n");
      out.write("                                </div>\n");
      out.write("                                <div class=\"full testimonial_cont text_align_center cross_layout\">\n");
      out.write("                                    <div class=\"cross_inner\">\n");
      out.write("                                        <h3>Due markes<br><strong class=\"ornage_color\">Rental</strong></h3>\n");
      out.write("                                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit ess</i>\n");
      out.write("                                        </p>\n");
      out.write("                                        <div class=\"full text_align_center margin_top_30\">\n");
      out.write("                                            <img src=\"icon/testimonial_qoute.png\">\n");
      out.write("                                        </div>\n");
      out.write("                                    </div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("\n");
      out.write("                    </div>\n");
      out.write("\n");
      out.write("                </div>\n");
      out.write("\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("        <!-- end clients -->\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("        ");
      org.apache.jasper.runtime.JspRuntimeLibrary.include(request, response, "layout/footer.jsp", out, false);
      out.write("\n");
      out.write("\n");
      out.write("        <!-- Javascript files-->\n");
      out.write("        <script src=\"js/jquery.min.js\"></script>\n");
      out.write("        <script src=\"js/popper.min.js\"></script>\n");
      out.write("        <script src=\"js/bootstrap.bundle.min.js\"></script>\n");
      out.write("        <script src=\"js/jquery-3.0.0.min.js\"></script>\n");
      out.write("        <script src=\"js/plugin.js\"></script>\n");
      out.write("        <!-- sidebar -->\n");
      out.write("        <script src=\"js/jquery.mCustomScrollbar.concat.min.js\"></script>\n");
      out.write("        <script src=\"js/custom.js\"></script>\n");
      out.write("        <!-- javascript -->\n");
      out.write("        <script src=\"js/owl.carousel.js\"></script>\n");
      out.write("        <script src=\"https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js\"></script>\n");
      out.write("        <script>\n");
      out.write("            $(document).ready(function () {\n");
      out.write("                $(\".fancybox\").fancybox({\n");
      out.write("                    openEffect: \"none\",\n");
      out.write("                    closeEffect: \"none\"\n");
      out.write("                });\n");
      out.write("\n");
      out.write("                $(\".zoom\").hover(function () {\n");
      out.write("\n");
      out.write("                    $(this).addClass('transition');\n");
      out.write("                }, function () {\n");
      out.write("\n");
      out.write("                    $(this).removeClass('transition');\n");
      out.write("                });\n");
      out.write("            });\n");
      out.write("        </script>\n");
      out.write("    </body>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }

  private boolean _jspx_meth_c_forEach_0(PageContext _jspx_page_context)
          throws Throwable {
    PageContext pageContext = _jspx_page_context;
    JspWriter out = _jspx_page_context.getOut();
    //  c:forEach
    org.apache.taglibs.standard.tag.rt.core.ForEachTag _jspx_th_c_forEach_0 = (org.apache.taglibs.standard.tag.rt.core.ForEachTag) _jspx_tagPool_c_forEach_var_items.get(org.apache.taglibs.standard.tag.rt.core.ForEachTag.class);
    _jspx_th_c_forEach_0.setPageContext(_jspx_page_context);
    _jspx_th_c_forEach_0.setParent(null);
    _jspx_th_c_forEach_0.setItems((java.lang.Object) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${stafflist}", java.lang.Object.class, (PageContext)_jspx_page_context, null));
    _jspx_th_c_forEach_0.setVar("staff");
    int[] _jspx_push_body_count_c_forEach_0 = new int[] { 0 };
    try {
      int _jspx_eval_c_forEach_0 = _jspx_th_c_forEach_0.doStartTag();
      if (_jspx_eval_c_forEach_0 != javax.servlet.jsp.tagext.Tag.SKIP_BODY) {
        do {
          out.write("\n");
          out.write("                            <div class=\"col-xl-4 col-lg-4 col-md-4 col-sm-6 margin\">\n");
          out.write("                                <div class=\"brand_box\">\n");
          out.write("                                    <img src=\"");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${staff.getImglink()}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("\" alt=\"img\" />\n");
          out.write("                                    <h3><strong class=\"red\">100.000đ/h</strong></h3>\n");
          out.write("                                    <span>");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${staff.getName()}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("</span>\n");
          out.write("                                    <i><img src=\"images/star.png\"/></i>\n");
          out.write("                                    <i><img src=\"images/star.png\"/></i>\n");
          out.write("                                    <i><img src=\"images/star.png\"/></i>\n");
          out.write("                                    <i><img src=\"images/star.png\"/></i>\n");
          out.write("                                    <br/><br/>\n");
          out.write("                                    <a style=\"color: White; background-color:red;text-decoration:none; padding: 10px 15px;margin: 20px;\"href=\"seeDetail?sid=");
          out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${staff.getId()}", java.lang.String.class, (PageContext)_jspx_page_context, null));
          out.write("\">Xem chi tiết</a>\n");
          out.write("                                </div>\n");
          out.write("                            </div>\n");
          out.write("                        ");
          int evalDoAfterBody = _jspx_th_c_forEach_0.doAfterBody();
          if (evalDoAfterBody != javax.servlet.jsp.tagext.BodyTag.EVAL_BODY_AGAIN)
            break;
        } while (true);
      }
      if (_jspx_th_c_forEach_0.doEndTag() == javax.servlet.jsp.tagext.Tag.SKIP_PAGE) {
        return true;
      }
    } catch (Throwable _jspx_exception) {
      while (_jspx_push_body_count_c_forEach_0[0]-- > 0)
        out = _jspx_page_context.popBody();
      _jspx_th_c_forEach_0.doCatch(_jspx_exception);
    } finally {
      _jspx_th_c_forEach_0.doFinally();
      _jspx_tagPool_c_forEach_var_items.reuse(_jspx_th_c_forEach_0);
    }
    return false;
  }
}
