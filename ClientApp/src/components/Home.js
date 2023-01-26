import React, { Component } from 'react';
import './Home.css';
import {Routes, Route, useNavigate} from 'react-router-dom';
import { Programmering } from './Programmering';

export const Home = (props) => {
  const navigate = useNavigate();

  const NavigateToProgrammering = () => {
      // 👇️ navigate to /contacts
      navigate('/programmering');
  };

  return (
      <div>
        <img className='bannerfoto' src="..\images\2000.jpg" alt="foto "></img>
        <div className='overons'>
          <div className='textoverOns'>
        <h1>over ons</h1>
        <p>"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."</p>
        </div>
        <div className='divFotoOverOns'>
        <img className='fotoOverOns' src='..\images\female-mime-making-hand-frame.jpg' alt='foto over ons'></img>
        </div>
        </div>
        <div className='programmering'>
        <div className='programmeringfoto'>

        <img className='fotoOverOns' src='..\images\female-mime-making-hand-frame.jpg' alt='foto over ons'></img>
        </div>
        <div className='programmeringtext'>

      <h2>programmering</h2>
      <p>"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."</p>
      <p><button onClick={NavigateToProgrammering}>Programmering</button></p>    
      <div>
          <Routes>
              <Route 
              path="/programmering" 
              // require auth
              element={<Programmering />} 
              />
          </Routes>
      </div>      
      </div>
      </div>
      </div>
    );
}
