using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class FakeTSS : MonoBehaviour
{
    [SerializeField] float secondsToUpdate = 3f;
    private float timer;

    private void Start()
    {
        Fake_Vitals();
    }


    public void Fake_Vitals()
    {
         Debug.Log("Starting vitals update coroutine...");
        StartCoroutine(UpdateVitals());
    }

    IEnumerator UpdateVitals()
    {
        while (true)
        {
            Debug.Log("Test"); 
            //AstronautInstance.User.VitalsData.eva_time = 69;
            yield return new WaitForSeconds(secondsToUpdate);
            
            // Update vitals with random values
            AstronautInstance.User.vitals.co2_production = UnityEngine.Random.Range(0.05f, 0.15f);
            AstronautInstance.User.vitals.oxy_consumption = UnityEngine.Random.Range(0.05f, 0.15f);
            //AstronautInstance.User.VitalsData.batt_percentage = UnityEngine.Random.Range(90f, 100f);
            //AstronautInstance.User.VitalsData.oxy_sec_storage = UnityEngine.Random.Range(90f, 100f);
            //AstronautInstance.User.VitalsData.suit_pressure = UnityEngine.Random.Range(0.8f, 5.2f);
            //AstronautInstance.User.VitalsData.sub_pressure = UnityEngine.Random.Range(15f, 25f);
            //AstronautInstance.User.VitalsData.o2_pressure = UnityEngine.Random.Range(0.8f, 5.2f);
            //AstronautInstance.User.VitalsData.o2_rate = UnityEngine.Random.Range(50f, 90f);
            //AstronautInstance.User.VitalsData.h2o_gas_pressure = UnityEngine.Random.Range(8f, 15f);
            //AstronautInstance.User.VitalsData.h2o_liquid_pressure = UnityEngine.Random.Range(18f, 25f);
            //AstronautInstance.User.VitalsData.sop_pressure = UnityEngine.Random.Range(6f, 12f);
            //AstronautInstance.User.VitalsData.sop_rate = UnityEngine.Random.Range(1f, 3f);
            AstronautInstance.User.vitals.heart_rate = UnityEngine.Random.Range(50f, 160f);
            //AstronautInstance.User.VitalsData.fan_tachometer = UnityEngine.Random.Range(1000f, 3000f);
            //AstronautInstance.Usesr.VitalsData.battery_capacity = UnityEngine.Random.Range(3000f, 5000f);
            AstronautInstance.User.vitals.temperature = UnityEngine.Random.Range(50f, 90f);
            //AstronautInstance.User.VitalsData.battery_percentage = UnityEngine.Random.Range(70f, 100f);
            //AstronautInstance.User.VitalsData.battery_outputput = UnityEngine.Random.Range(200f, 400f);
            //AstronautInstance.User.VitalsData.oxygen_primary_time = UnityEngine.Random.Range(1000f, 2000f);
            //AstronautInstance.User.VitalsData.oxygen_secondary_time = UnityEngine.Random.Range(1500f, 2500f);
            //AstronautInstance.User.VitalsData.water_capacity = UnityEngine.Random.Range(2000f, 4000f);

            // Increment timer
            timer += 3f;

            // Battery time left
            //TimeSpan batteryTime = TimeSpan.FromMinutes(5) - timeSpan;
            //AstronautInstance.User.VitalsData.batt_time_left = batteryTime.Hours + batteryTime.Minutes + batteryTime.Seconds;

            // O2 time left
            //TimeSpan o2Time = TimeSpan.FromMinutes(5) - timeSpan;
            //AstronautInstance.User.VitalsData.oxy_time_left = o2Time.Hours + o2Time.Minutes + o2Time.Seconds;


            // Publish VitalsUpdatedEvent
            EventBus.Publish<UpdatedVitalsEvent>(new UpdatedVitalsEvent(AstronautInstance.User.vitals));

        }
    }

}
