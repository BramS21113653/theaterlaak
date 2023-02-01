import React, {useState} from 'react'
import List from "./List"

export const Searchbar = () => {
    const [inputText, setInputText] = useState("");
    let inputHandler = (e) => {
      //convert input text to lower case
      var lowerCase = e.target.value.toLowerCase();
      setInputText(lowerCase);
    };
  
    return (
      <div className="main">
        <h2>Zoek een voorstelling op titel</h2>
        <div className="search">
          <input
            id="outlined-basic"
            onChange={inputHandler}
            label="Search"
          />
        </div>
        <List input={inputText} />
      </div>
    );
};

