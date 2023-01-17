import React from 'react';
import './Footer.css';

const Footer = () => {

    return <footer>
        <div class="row">
            <div class="column">
                <p className='text_footer'>
                    ©2022 TheaterLaak
                </p>
            </div>
            <div class="column">
                <p>
                    <img className='Logo_onderin' src='..\Images\Theater_logo-black.png' alt='Theater Laak' width='60' height='80'></img>
                </p>
            </div>
            <div class="column">
                <p>
                    <a href="https://twitter.com/laaktheater"><img className='twitter_logo' src='..\Images\Twitter_logo.png' alt='Twitter' width='30' height='30'></img></a>
                </p>
                <p>
                    <a href="https://www.instagram.com/laaktheater/?__coig_restricted=1"><img className='insta_logo' src='..\Images\Instagram_logo.jpg' alt='Instagram' width='30' height='30'></img></a>
                </p>
                <p>
                    <a href="https://www.facebook.com/Laaktheater"><img className='facebook_logo' src='..\Images\Facebook_logo.png' alt='Facebook' width='30' height='30'></img></a>
                </p>
            </div>
        </div>
    </footer>
};

export default Footer;

