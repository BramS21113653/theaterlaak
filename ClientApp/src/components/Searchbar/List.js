import { React, useState, useEffect } from 'react'
import {Routes, Route, useNavigate} from 'react-router-dom';
import Betaling from "../Betaling";
// import Programmering from "./ListData"

export const Programmering = () => {
    const [data, setData] = useState([]);
  
    useEffect(() => {
      // fetch data
      const dataFetch = async () => {
        const data = await (
          await fetch(
            "https://localhost:7003/api/gelegenheid/all"
          )
        ).json();
  
        // set state when the data received
        setData(data);
      };
  
      dataFetch();
    }, []);
    const dataSorted = data.sort((a, b) =>
    a.aanvangstijd > b.aanvangstijd ? 1 : -1,);    
    console.log(dataSorted);
    return (dataSorted);
  }

function List(props) {
    const navigate = useNavigate();

    const NavigateToBetaling = () => {
        // 👇️ navigate to /contacts
        navigate('/betaling');
    };
    //create a new array by filtering the original array
    console.log(Programmering());
    const filteredData = Programmering().filter((el) => {
        //if no input the return the original
        if (props.input === '') {
            return el;
        }
        //return the item which contains the user input
        else {
            return el.voorstelling.titel.toLowerCase().includes(props.input)
        }
    })
    return (
        <ul>
            {filteredData.map((gelegenheid) => (
                // <li key={gelegenheid.titel}>{gelegenheid.text}</li>
                <div key={gelegenheid.gelegenheidId}><br></br>
                Voorstelling {gelegenheid.voorstelling.titel}<br></br>
                Zaal {gelegenheid.zaalId}<br></br>
                Aanvangstijd {gelegenheid.aanvangstijd}<br></br>
                Eindtijd {gelegenheid.eindtijd}<br></br>
                <button onClick={NavigateToBetaling}>Boek ticket</button>
                </div>
              ))}
              <Routes>
                <Route 
                path="/betaling" 
                // require auth
                element={<Betaling />} 
                />
              </Routes>
        </ul>
    )
}

export default List;