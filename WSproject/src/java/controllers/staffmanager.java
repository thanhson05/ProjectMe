/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controllers;

import DAO.allDao;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import models.Staff;
import models.Transaction;

/**
 *
 * @author Admin
 */
@WebServlet(name = "staffmanager", urlPatterns = {"/staffmanager"})
public class staffmanager extends HttpServlet {

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
        String action = request.getParameter("action");
        if (action == null) {
            response.sendRedirect("http://localhost:8080/WSproject/home");
        }
        allDao dao = new allDao();
        if (action.equals("see")) {
            ArrayList<Staff> staffList = dao.getAllStaff();
            request.setAttribute("stafflist", staffList);
            request.getRequestDispatcher("saff.jsp").forward(request, response);
        }
        if (action.equals("delete")) {
            int id = Integer.parseInt(request.getParameter("sid"));
            dao.deleteStaff(id);
            response.sendRedirect("http://localhost:8080/WSproject/staffmanager?action=see");
        }
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
        String action = request.getParameter("action");
        if (action == null) {
            response.sendRedirect("http://localhost:8080/WSproject/home");
        }
        allDao dao = new allDao();
        String name = request.getParameter("name");
        String phone = request.getParameter("phone");
        String address = request.getParameter("address");
        String imglink = request.getParameter("img");
        if (action.equals("edit")) {
            int id = Integer.valueOf(request.getParameter("id"));
            response.getWriter().println(id);
            response.getWriter().println(name);
            response.getWriter().println(phone);
            response.getWriter().println(address);
            response.getWriter().println(imglink);
//            dao.updateStaff(name, phone, address, imglink, id);
        }
        if (action.equals("add")) {
            dao.insertStaff(name, phone, address, imglink);
        }
        ArrayList<Staff> staffList = dao.getAllStaff();
        request.setAttribute("stafflist", staffList);
//        request.getRequestDispatcher("saff.jsp").forward(request, response);
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
