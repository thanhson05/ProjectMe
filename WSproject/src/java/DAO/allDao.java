/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import models.*;

/**
 *
 * @author Admin
 */
public class allDao extends DBContext {

    PreparedStatement stm;
    ResultSet rs;

    public ArrayList<User> getAllUsers() {
        ArrayList<User> list = new ArrayList<>();
        try {
            String sql = "select*from Users ";
            stm = connection.prepareCall(sql);
            rs = stm.executeQuery();
            while (rs.next()) {
                list.add(new User(rs.getInt("id"), rs.getString("username"), rs.getString("pass"),
                        rs.getString("name"), rs.getString("phone"), rs.getString("address"), rs.getString("isAmin")));
            }
        } catch (Exception e) {
        }
        return list;
    }

    public User getUsersById(int id) {
        try {
            String sql = "select*from Users where id=?";
            stm = connection.prepareCall(sql);
            stm.setInt(1, id);
            rs = stm.executeQuery();
            while (rs.next()) {
                User u = new User(rs.getInt("id"), rs.getString("username"), rs.getString("pass"),
                        rs.getString("name"), rs.getString("phone"), rs.getString("address"), rs.getString("isAmin"));
                return u;

            }
        } catch (Exception e) {
        }
        return null;
    }

    public ArrayList<Staff> getAllStaff() {
        ArrayList<Staff> list = new ArrayList<>();
        try {
            String sql = "select*from Staff ";
            stm = connection.prepareCall(sql);
            rs = stm.executeQuery();
            while (rs.next()) {
                list.add(new Staff(rs.getInt("id"), rs.getString("Name"), rs.getString("phone"),
                        rs.getString("addresss"), rs.getString("imglink")));
            }
        } catch (Exception e) {
        }
        return list;
    }

    public Staff getStaffById(int id) {
        ;
        try {
            String sql = "select * from Staff where id = ?";
            stm = connection.prepareCall(sql);
            stm.setInt(1, id);
            rs = stm.executeQuery();
            while (rs.next()) {
                Staff s = new Staff(rs.getInt("id"), rs.getString("Name"), rs.getString("phone"),
                        rs.getString("addresss"), rs.getString("imglink"));
                return s;
            }
        } catch (Exception e) {
        }
        return null;
    }

    public ArrayList<Staff> searchByName(String name) {
        ArrayList<Staff> list = new ArrayList<>();
        try {
            String sql = "  select * from Staff where Name like ?";
            stm = connection.prepareCall(sql);
            stm.setString(1, "%" + name + "%");
            rs = stm.executeQuery();
            while (rs.next()) {
                list.add(new Staff(rs.getInt("id"), rs.getString("Name"), rs.getString("phone"),
                        rs.getString("addresss"), rs.getString("imglink")));
            }
        } catch (Exception e) {
        }
        return list;
    }

    public ArrayList<Staff> get3Staff() {
        ArrayList<Staff> list = new ArrayList<>();
        try {
            String sql = "select top 3 * from Staff ";
            stm = connection.prepareCall(sql);
            rs = stm.executeQuery();
            while (rs.next()) {
                list.add(new Staff(rs.getInt("id"), rs.getString("Name"), rs.getString("phone"),
                        rs.getString("addresss"), rs.getString("imglink")));
            }
        } catch (Exception e) {
        }
        return list;
    }

    public ArrayList<Transaction> getAllTransactions() {
        ArrayList<Transaction> list = new ArrayList<>();
        try {
            String sql = "select t.*, u.name as username, s.Name as sname from Transactions t, Users u, Staff s \n"
                    + "where t.Staffid = s.id and t.Userid = u.id";
            stm = connection.prepareCall(sql);
            rs = stm.executeQuery();
            while (rs.next()) {
                list.add(new Transaction(rs.getInt("id"), new User(rs.getString("username")), new Staff(rs.getString("sname")),
                        rs.getInt("totaltime"), rs.getString("total"), rs.getString("status")));
            }
        } catch (Exception e) {
        }
        return list;
    }

    public ArrayList<Feedback> getAllFeedback() {
        ArrayList<Feedback> list = new ArrayList<>();
        try {
            String sql = "  select distinct   f.*, u.name as username from Feedback f, Users u where u.id = f.Userid ";
            stm = connection.prepareCall(sql);
            rs = stm.executeQuery();
            while (rs.next()) {
                list.add(new Feedback(rs.getInt("Id"), new User(rs.getString("username")), rs.getString("mess"), rs.getInt("rate")));
            }
        } catch (Exception e) {
        }
        return list;
    }

    public void insertFeedback(int uid, String mess, int rate) {
        try {
            String sql = "insert into Feedback(Userid,mess,rate) values(?,?,?);";
            stm = connection.prepareCall(sql);
            stm.setInt(1, uid);
            stm.setString(2, mess);
            stm.setInt(3, rate);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void deleteFeedback(int id) {
        try {
            String sql = "DELETE FROM Feedback WHERE Id = ?";
            stm = connection.prepareCall(sql);
            stm.setInt(1, id);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void deleteTrans(int id) {
        try {
            String sql = "DELETE FROM Transactions WHERE Id = ?";
            stm = connection.prepareCall(sql);
            stm.setInt(1, id);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void deleteUser(int id) {
        try {
            String sql = "delete from Transactions where Userid = ?  DELETE FROM Users WHERE id = ?";
            stm = connection.prepareCall(sql);
            stm.setInt(1, id);
            stm.setInt(2, id);

            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void deleteStaff(int id) {
        try {
            String sql = "delete from Transactions where Staffid = ?  DELETE FROM Staff WHERE id = ?";
            stm = connection.prepareCall(sql);
            stm.setInt(1, id);
            stm.setInt(2, id);

            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void insertTrans(int sid, int uid, int totaltime, String status) {
        try {
            String sql = "insert into Transactions(Userid,Staffid,totaltime,total,status) values(?,?,?,?,?);";
            stm = connection.prepareCall(sql);
            stm.setInt(1, uid);
            stm.setInt(2, sid);
            stm.setInt(3, totaltime);
            stm.setString(4, String.valueOf(totaltime * 100000));
            stm.setString(5, status);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void insertUser(String user, String pass, String name, String phone, String address) {
        try {
            String sql = "insert into Users(username,pass, name, phone,address,isAmin) values(?,?,?,?,?,'false');";
            stm = connection.prepareCall(sql);
            stm.setString(1, user);
            stm.setString(2, pass);
            stm.setString(3, name);
            stm.setString(4, phone);
            stm.setString(5, address);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void insertStaff(String name, String phone, String address, String img) {
        try {
            String sql = "insert into Staff(Name, phone,addresss,imglink) values(?,?,?,?);";
            stm = connection.prepareCall(sql);
            stm.setString(1, name);
            stm.setString(2, phone);
            stm.setString(3, address);
            stm.setString(4, img);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void updateStaff(String name, String phone, String address, String img, int id) {
        try {
            String sql = "update Staff Set Name=?, phone=?,addresss=?,imglink=? where id=?";
            stm = connection.prepareCall(sql);
            stm.setString(1, name);
            stm.setString(2, phone);
            stm.setString(3, address);
            stm.setString(4, img);
            stm.setInt(5, id);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }

    public void updateUser(String username, String name, String phone, String address, int id) {
        try {
            String sql = "  update Users Set username=?, name=?,address=?,phone=? where id=? ";
            stm = connection.prepareCall(sql);
            stm.setString(1, username);
            stm.setString(2, name);
            stm.setString(3, address);
            stm.setString(4, phone);
            stm.setInt(5, id);
            stm.executeUpdate();
        } catch (Exception e) {
        }
    }
}
