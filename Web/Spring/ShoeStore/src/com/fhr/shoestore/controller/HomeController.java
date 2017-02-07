package com.fhr.shoestore.controller;

import org.apache.log4j.Logger;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HomeController {
	private static Logger logger=Logger.getLogger(HomeController.class);
	@RequestMapping("/home")
	public String home(){
		return "index";
	}
}
