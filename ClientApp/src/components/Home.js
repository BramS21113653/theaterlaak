import React, { Component } from 'react';
import './Home.css';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);

    this.state = {
      test: null
    };
  }

  componentDidMount() {
    fetch('https://localhost:7003/api/Groep')
    .then(response => response.text())
    .then(data => this.setState({ test: data }))
  }

  render() {
    const { test } = this.state;
    return (
      <div>
        <h1>Doet hij het? { test }</h1>

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
      <button>programmering</button>

      </div>

      </div>
      </div>
    );
  }
}
