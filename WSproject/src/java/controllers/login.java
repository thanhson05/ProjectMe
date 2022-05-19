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
import javax.servlet.http.HttpSession;
import models.User;

/**
 *
 * @author Admin
 */
@WebServlet(name = "login", urlPatterns = {"/login"})
public class login extends HttpServlet {

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
        HttpSession session = request.getSession();

        String action = request.getParameter("action");
        if (action == null) {
            action = "login";
        }
        if (action.equalsIgnoreCase("login")) {
            request.getRequestDispatcher("login.jsp").forward(request, response);
        }
        if (action.equalsIgnoreCase("logout")) {
            session.removeAttribute("user");
            response.sendRedirect("home");
        }
        if (action.equals("checkLogin")) {
            String user_email = request.getParameter("user_email").trim();
            String user_pass = request.getParameter("user_pass").trim();
            allDao dao = new allDao();
            ArrayList<User> userlist = dao.getAllUsers();
            String isadmin = "";
            int check = 0;
            for (User user : userlist) {
                if (user.getUsername().trim().equals(user_email) && user.getPass().trim().equals(user_pass)) {
                    check++;
                    isadmin = user.getIsAdmin();
                    session.setAttribute("userid", user.getId());
                }
            }
            if (check == 1) {
                session.setAttribute("user", user_email);

                if (isadmin.trim().equals("true")) {
                    session.setAttribute("admin", "true");
                } else {
                    session.setAttribute("admin", "false");
                }
                response.sendRedirect("home");

            } else {
                request.setAttribute("mess", "Mật khẩu hoặc tài khoản không đúng. Vui lòng nhập lại!");
                request.getRequestDispatcher("login.jsp").forward(request, response);

            }

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
        processRequest(request, response);
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
