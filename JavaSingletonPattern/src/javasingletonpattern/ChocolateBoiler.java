/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javasingletonpattern;

import static javasingletonpattern.JavaSingletonPattern.boiler;

/**
 *
 * @author prodromalex
 */
public class ChocolateBoiler {
    private boolean empty;
    private boolean boiled;
    
    //We have a static variable to hold our one instance of the class ChocolateBoiler.
    private volatile static ChocolateBoiler uniqueInstance;
    
    public static ChocolateBoiler getInstance() {
        //The getInstance() method gives us a way to instantiate the class and also to return an instance of it.
        if (uniqueInstance == null) {
            synchronized (ChocolateBoiler.class) {
                if (uniqueInstance == null) {
                    uniqueInstance = new ChocolateBoiler();
                    System.out.println(uniqueInstance);
                    //If it's not synchronized there are 2 created instances  
                }
                
            }
        }
        return uniqueInstance;
    }
    
    private ChocolateBoiler() {
        //Our constructor is declared private; only ChocolateBoiler can instantiate this class!
        empty = true;
        boiled = false;
    }
    public void fill() {
        // fill the boiler with a milk/chocolate mixture
        if (isEmpty()) {
            empty = false;
            boiled = false;
        }
    }
    public void drain() {
        //drains and empties the boiler
        if (!isEmpty() && isBoiled()) {
            empty = true;
        }
    }
    public void boil() {
        //boils the liquid inside
        if (!isEmpty() && !isBoiled()) {
            boiled = true;
        }
    }
    public boolean isEmpty() {
        //returns the emptyness status
        return empty;
    }
    public boolean isBoiled() {
        //returns the boiled status
        return boiled;
    }
}
