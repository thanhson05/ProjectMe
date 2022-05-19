/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controllers;

import DAO.allDao;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import models.Staff;

/**
 *
 * @author Admin
 */
@WebServlet(name = "seeDetail", urlPatterns = {"/seeDetail"})
public class seeDetail extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        allDao dao = new allDao();
        int id = Integer.parseInt(request.getParameter("sid"));

        Staff s = dao.getStaffById(id);
        request.setAttribute("s", s);
        request.getRequestDispatcher("detailSV.jsp").forward(request, response);

    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);

    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        if (request.getSession().getAttribute("userid") == null) {
            response.sendRedirect("login");
        } else {
            int sid = Integer.valueOf(request.getParameter("sid"));
            int uid = Integer.valueOf(request.getSession().getAttribute("userid").toString());
            int totaltime = Integer.valueOf(request.getParameter("totaltime"));
            String status = "Chưa Hoàn Thành";
            allDao dao = new allDao();
            response.getWriter().println(totaltime);
            dao.insertTrans(sid, uid, totaltime, status);
            Staff st = dao.getStaffById(sid);
            request.setAttribute("st", st);
            request.setAttribute("totaltime", totaltime);
            request.setAttribute("totalbill", totaltime * 100000);
            request.getRequestDispatcher("orderdetail.jsp").forward(request, response);
        }
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
