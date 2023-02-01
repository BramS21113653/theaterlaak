import React, { Component } from 'react';
// import {useState, useEffect} from 'react';
import { Searchbar } from './Searchbar/Searchbar';

export const Programmering = () => {
  // const [data, setData] = useState([]);
  // useEffect(() => {
  //   // fetch data
  //   const dataFetch = async () => {
  //     const data = await (
  //       await fetch(
  //         "https://localhost:7003/api/gelegenheid/all"
  //       )
  //     ).json();

  //     // set state when the data received
  //     setData(data);
  //   };

  //   dataFetch();
  // }, []);

  return (
    <div>
      <Searchbar/>
      {/* {data.map(gelegenheid => (
        <div key={gelegenheid.voorstelling.titel}><br></br>
        Voorstelling {gelegenheid.voorstelling.titel}<br></br>
        Zaal {gelegenheid.zaalId}<br></br>
        Aanvangstijd {gelegenheid.aanvangstijd}<br></br>
        Eindtijd {gelegenheid.eindtijd}<br></br>
        <button>Boek ticket</button></div>
      ))} */}
      <br></br>
    </div>
  )
}
