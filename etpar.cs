            DocumentReference docRef = db.Collection("users").Document("alovelace");
            await docRef.UpdateAsync("favorites", FieldValue.ArrayUnion("computers"));  
