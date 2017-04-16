/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javasingletonpattern;

/**
 *
 * @author prodromalex
 */
public class JavaSingletonPattern {

    static ChocolateBoiler boiler;
    
    public static void main(String[] args) {
        
        
        new Thread(() -> {
            boiler=ChocolateBoiler.getInstance();
        }).start();
        
        new Thread(() -> {
            boiler=ChocolateBoiler.getInstance();           
        }).start();
    }
    
}
