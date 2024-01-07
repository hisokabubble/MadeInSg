using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class MyDatabase : MonoBehaviour
{
    DatabaseReference mDatabaseRef;
    

    // Start is called before the first frame update
    void Start()
    {
        mDatabaseRef = FirebaseDatabase.DefaultInstance.RootReference;
        //WriteNewUser(mDatabaseRef, name, email, score);
    }

    private void WriteNewUser (DatabaseReference mDatabaseRef, string name, string email, int score)
    {
       // User user = new User(name, email, score);
        //string json = JsonUtility.ToJson(user);
       // mDatabaseRef.Child("users").Child(name).SetRawJsonValueAsync(json);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
