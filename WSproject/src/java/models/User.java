/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package models;

/**
 *
 * @author Admin
 */
public class User {
    int id;
    String username ;
    String pass;
    String name;
    String phone ;
    String address;
    String isAdmin;

    public User(String username, String pass) {
        this.username = username;
        this.pass = pass;
    }

    public User(String name) {
        this.name = name;
    }

    public User(int id, String username, String pass, String name, String phone, String address, String isAdmin) {
        this.id = id;
        this.username = username;
        this.pass = pass;
        this.name = name;
        this.phone = phone;
        this.address = address;
        this.isAdmin = isAdmin;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPass() {
        return pass;
    }

    public void setPass(String pass) {
        this.pass = pass;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getIsAdmin() {
        return isAdmin;
    }
    public boolean itIsAdmin(){
        return isAdmin.equals("true");
    }

    public void setIsAdmin(String isAdmin) {
        this.isAdmin = isAdmin;
    }
    
}
