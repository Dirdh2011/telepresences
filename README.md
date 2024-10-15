# **Availing Telepresence for the Expeditious Retrieval of Datum**

## **Project Overview**
This project integrates **Industry 4.0** principles using **Augmented Reality (AR)**, **IoT**, and **SCADA** for real-time monitoring and control of industrial processes. It enables remote supervision of tanks and process variables like temperature, pressure, and fluid levels via mobile devices. The system uses **Node-RED**, **MQTT**, and **PCCC protocol** to communicate between the **PLC**, **IoT cloud**, and **AR interfaces**. Developed at **Servilink Systems Ltd**, it showcases the efficiency of modern automation techniques and smart industrial monitoring.

## **System Architecture**
The project consists of two tanks:
- **Mixing Tank**: Operates pumps to combine resin, pigment, and water, stirring based on the tank level.
- **Heating Tank**: Heats fluid to a set temperature, monitored by sensors.
![system](https://github.com/user-attachments/assets/46096986-38e8-4174-b84d-ab5dd232f5f3)

The process includes:
1. **Start Process**: Begins when the start button is pressed.
2. **Mixing and Heating**: Based on sensor feedback and timer-controlled actions.
3. **Data Acquisition**: Data flows to the AR interface, IoT dashboard, and SCADA system for real-time monitoring.

![i2](https://github.com/user-attachments/assets/b892d76a-895b-41af-8ba0-28dd700fe271)


## **Key Features**
- **Real-Time Data Acquisition**: Continuous monitoring of process variables.
- **AR Integration**: View real-time tank data by scanning QR codes.
- **IoT Cloud**: Data is sent to the cloud using MQTT protocol for remote monitoring.
- **SCADA Interface**: A traditional SCADA interface is built using **FactoryTalk SCADA**.
- **Node-RED Dashboard**: Visualizes live sensor data in an intuitive interface.

## **Technologies Used**
### **Hardware**:
- Raspberry Pi 4
- PLC (MicroLogix 1400 B)
- DC Motors, Pt-100 Temperature Sensor, Float Level Sensors
- Pumps, Heater, Start/Stop Buttons, Lamps

### **Software**:
- Node-RED, MQTT, PCCC Protocol
- FactoryTalk SCADA
- AR Mobile Application
- IoT Cloud Integration (Node-RED and MQTT)





## **Usage**
- Start the process using the push buttons.
- Monitor the tank levels, temperature, and other variables via the AR interface or the IoT dashboard.
- Use SCADA for real-time control and monitoring of the entire system.
- Node-RED provides a dashboard for additional insights and control of the process.

## **Results**
- The system successfully integrates AR and IoT, providing real-time data for industrial monitoring.
- Data was validated via the AR mobile application, IoT cloud, and SCADA screens.
  
### **Images:**
1. **PLC Scan**  
   ![image](https://github.com/user-attachments/assets/d8aa7438-c4e1-45cc-ab25-5a2699c7a631)


2. **Mixing Tank Scan**  
  ![mixing tank](https://github.com/user-attachments/assets/513fd90d-07aa-4757-89c1-11ff8ab7c096)


3. **Heating Tank Scan**  
   
![heating](https://github.com/user-attachments/assets/420093f6-3a8b-4b61-bb97-8690949248e9)

4. **IoT Dashboard**  
   ![iot1](https://github.com/user-attachments/assets/fab531d2-edad-4e38-b1e3-78c22325d8ee)
   ![iot2](https://github.com/user-attachments/assets/5b61c56b-2116-4f12-9f9b-8d16a40f0bd5)
   ![iot3](https://github.com/user-attachments/assets/cdacdab8-cde1-4598-aa38-3859a9fea2cc)


   


6. **SCADA Dashboard**  
  ![scada1](https://github.com/user-attachments/assets/3b52254a-08f7-411f-92da-79982e7d1f2f)
![i](https://github.com/user-attachments/assets/54020b57-3ac6-463c-a806-d091b24c5bf1)




## **Contact**
For more information, please contact **Dirdh Patel** at [pdirdh2011@gmail.com](mailto:pdirdh2011@gmail.com).

---

## **Submitted By**
- **PRITIKA RADHAKRISHNAN**
- **KABARIA PARTH A.**  
- **KANSARA HANEE M.**
- **PATEL DIRDH P.**  
 

## **Under the Guidance of**
- **Prof. (Dr.) Vipul A.**,  
  Dean, Faculty of Technology,  
  Dharmsinh Desai University,  
  Nadiad - 387 001 (External Guide)

- **Shah Mr. Mitesh Parmar**,  
  Project Engineer,  
  Servilink Systems Ltd.,  
  Vadodara - 390 007
