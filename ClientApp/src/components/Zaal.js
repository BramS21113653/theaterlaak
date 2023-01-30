import {useState, useEffect} from 'react';
import React from 'react';

export const Zaal = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    // fetch data
    const dataFetch = async () => {
      const data = await (
        await fetch(
          "https://localhost:7003/api/zaal/all"
        )
      ).json();

      // set state when the data received
      setData(data);
    };

    dataFetch();
  }, []);

  return (
    <div>
        <h1>Zaal reserveren</h1>
        {data.map(zaal => (
          <div>
            <div key={zaal.zaalId} style={{fontWeight: "bold"}}>
              Zaal {zaal.zaalId}<br></br>
              Aantal zitplaatsen: {zaal.aantalZitplaatsen}<br></br>
            </div>
            <div>Selecteer een datum<br></br>
              <select name="language" id="language" style={{color: "red"}}>
                <option value="vandaag" defaultValue>Vandaag</option>
                <option value="morgen">morgen</option>
                <option value="overmogen">overmogen</option>
                <option value="overovermorgen">overovermorgen</option>
              </select><br></br>
              <button style={{color: "red"}}>Reserveer zaal {zaal.zaalId}</button>
              <br></br><br></br>
            </div>
          </div>
        ))}
    </div>
  );
};

// benodigd voor boeking

// alles van zaal bekend
// datetime = datum in dropdown
// prijs                                      nog toevoegen aan zalen...
// user == currentuser

// ---->>>>> naar betaling wanneer betaling gelukt is, boeking naar db