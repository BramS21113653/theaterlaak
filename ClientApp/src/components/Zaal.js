import {useState} from 'react';
import React from 'react';

export const Zaal = () => {
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  const [err, setErr] = useState('');

  const handleClick = async () => {
    setIsLoading(true);

    try {
      const response = await fetch('https://localhost:7003/api/zaal/all', {
        method: 'GET',
        headers: {
          Accept: 'application/json',
        },
      });

      if (!response.ok) {
        throw new Error(`Error! status: ${response.status}`);
      }

      const result = await response.json();

      console.log('result is: ', JSON.stringify(result, null, 4));

      setData(result);
      console.log(data);
    } catch (err) {
      setErr(err.message);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div>
      {err && <h2>{err}</h2>}

      <button style={{backgroundColor: "SkyBlue"}} onClick={handleClick}>Laad alle zalen om een reservering te doen...</button>

      {isLoading && <h2>Loading...</h2>}

      <div>
        {data.map(zaal => (
          <div key={zaal.zaalId}><br></br>Zaal {zaal.zaalId}<br></br>Aantal zitplaatsen: {zaal.aantalZitplaatsen}<br></br><button>Reserveer zaal {zaal.zaalId}</button></div>
        ))}
        <br></br>
      </div>
    </div>
  );
};

